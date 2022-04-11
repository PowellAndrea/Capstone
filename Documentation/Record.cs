using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata_Manager.Models
{
   internal class Record
   {
      public Guid RecordId = Guid.NewGuid();
      private string RecordTitle { get; set; }
      private string RecordDescription { get; set; }
      private DateOnly DateCreated { get; set; }
      private Author[] Authors { get; set; }

   }
}
