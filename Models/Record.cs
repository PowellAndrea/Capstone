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
      internal string RecordTitle { get; set; }
      internal string FilePath { get; set; }
      internal string FileName { get; set; }
   }
}
