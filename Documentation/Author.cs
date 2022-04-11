using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata_Manager
{
   internal class Author
   {
      Guid AuthorId = Guid.NewGuid();

      private string AuthorFirstName { get; set; }
      private string AuthorLastName { get; set; }

   }
}
