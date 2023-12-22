using Ismogy.DB;
using Ismogy.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Ismogy.VM
{
    public class DelVM
    {
        public List<Zavod> zavod { get; set; }

        public Zavod SelectedZavod { get; set; }

        public CommandVM Delete { get; set; }

        public DelVM()
        {
            zavod = StudentContext.GetInstance().Zavods.ToList();

            Delete = new CommandVM(() => {
                try
                {
                    StudentContext.GetInstance().Zavods.Remove(SelectedZavod);
                    StudentContext.GetInstance().SaveChanges();
                    MessageBox.Show("Deleted");

                }
                catch
                {
                    MessageBox.Show("Error");
                }
            
            });




        }




    }
}
