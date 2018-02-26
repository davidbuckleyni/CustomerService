using CustomerService.Classes;
using CustomerService.Forms.Search;
using CustomerService.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace CustomerService.Forms.Notes
{
    public partial class frmNotes : Form
    {
        CustomersContext _db = new CustomersContext();
        public int CustomerId { get; set; }
        public int NotesId { get; set; }
        public bool IsEditMode { get; set; }
        public frmNotes()
        {
            InitializeComponent();


        }

        private void frmNotes_Load(object sender, EventArgs e)
        {

            if(this.IsEditMode ==true)
            {
                Note _note = new Note();
                
                _note = _db.GetNotesById(NotesId);
                txtTitle.Text = _note.Title;
                txtNotes.Text = _note.Notes;
                txtDescription.Text = _note.Description;

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Note _note = new Note();

            if (this.IsEditMode == true)
            {

                _note = _db.GetNotesById(NotesId);
            }

            _note.Title = txtTitle.Text;
            _note.Notes = txtNotes.Text;
            _note.Description = txtDescription.Text;
            _note.CustomerId = CustomerId;
            _note.CreatedDate = DateTime.Now;
            if (IsEditMode == true)
            {

                _db.SaveNote(_note);
                _db.SaveChanges();

                MessageBox.Show("Contact Saved", "Note has been Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                _db.AddToNotes(_note);
                _db.SaveNote(_note);
                MessageBox.Show("Note Saved", "Note has been Created", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            this.Close();
        }
    }
}
