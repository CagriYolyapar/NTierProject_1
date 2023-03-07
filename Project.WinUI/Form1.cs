using Project.BLL.GenericRepository.ConcRep;
using Project.ENTITIES.Models;
using Project.VM.VMClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _bookRep = new BookRepository();
        }
        BookRepository _bookRep;
        private void Form1_Load(object sender, EventArgs e)
        {
            lstBooks.DataSource = _bookRep.Select(x => new BookVM
            {
                ID = x.ID,
                Title = x.Title,
                PageNumber = x.PageNumber,
                AuthorName = x.Author.FirstName ,
                AuthorSurName =x.Author.LastName
            }).ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        { //BookVM'in ismi yazılmıs mı 15 karakterden az mı 3 karakterde fazla mı (Validation Rules) 
            Book book = new Book();
            book.Title = txtIsim.Text;
            _bookRep.Add(book);
            lstBooks.DataSource = _bookRep.GetActives();

        }
        BookVM _selectedVM;
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (_selectedVM != null)
            {
                Book secilen = _bookRep.Find(_selectedVM.ID);
                _selectedVM.Title = txtIsim.Text;
                _bookRep.Update(secilen);
                _selectedVM = null;
            }
        }

        private void btnGetDeleteds_Click(object sender, EventArgs e)
        {
            lstBooks.DataSource = _bookRep.GetPassives();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //if (_selected != null)
            //{
                
            //    _bookRep.Delete(_selected);
            //    _selected = null;
            //}
        }

        private void btnGetPures_Click(object sender, EventArgs e)
        {

        }

        private void btnGetModifieds_Click(object sender, EventArgs e)
        {
            lstBooks.DataSource = _bookRep.GetModifieds();
        }

        private void lstBooks_Click(object sender, EventArgs e)
        {
            if (lstBooks.SelectedIndex > -1)
            {
                _selectedVM = lstBooks.SelectedItem as BookVM;
                txtIsim.Text = _selectedVM.Title;
            }
        }

        private void btnKitapVeKategoriler_Click(object sender, EventArgs e)
        {

            lstBooks.DataSource = null;
            if(_selectedVM != null)
            {
                BookWithCategoryVM bvm = new BookWithCategoryVM()
                {
                    Title = _selectedVM.Title,
                };


                Book orijinal = _bookRep.Find(_selectedVM.ID);

                foreach (BookCategory item in orijinal.BookCategories)
                {
                    bvm.Categories.Add(item.Category.CategoryName);
                }

                lstBooks.Items.Add(bvm);
                foreach (string item in bvm.Categories)
                {
                    lstBooks.Items.Add(item);
                }



                //foreach (BookCategory item in orijinal.BookCategories)
                //{
                //    lstBooks.Items.Add(item.Category);
                //}

               
            }
        }
    }
}
