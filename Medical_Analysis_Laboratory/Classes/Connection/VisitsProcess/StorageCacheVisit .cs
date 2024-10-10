using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Analysis_Laboratory.Classes.Connection.VisitsProcess
{
    public class StorageCacheVisit
    {
        public Guid Id { get; set; }
        public int NumberOfTest { get; set; }
        public ComboBox NameCompoTest { get; set; }
        public TextBox NameTextValue { get; set; }
        public RichTextBox NameRichDiagnosis { get; set; }

        public static List<StorageCacheVisit> StorageCacheVisits = new List<StorageCacheVisit>();
        public static List<StorageCacheVisit> StorageCacheVisitsTemp = new List<StorageCacheVisit>();

        public StorageCacheVisit()
        {
            Id = Guid.NewGuid();
        }
        public void RemoveItemById(Guid id,DataGridView DGV)
        {
            var itemToRemove = StorageCacheVisits.FirstOrDefault(item => item.Id == id);

            if (itemToRemove != null)
            {
                StorageCacheVisits.Remove(itemToRemove);
                DGV.Rows.Remove(DGV.CurrentRow);
                Console.WriteLine("Success deleted .");
            }
            else
            {
                Console.WriteLine("Not Found .");
            }
        }

    }

}
