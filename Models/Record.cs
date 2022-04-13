using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata_Manager
{
   public class Record
   {
      #region Properties
      // Standard metdata fields
      public string Title { get => Title; set => Title = value; }
      public string Format { get => Format; set => Format = value; }    // example:  "pdf", "paper"

      // Move these to child class = digital record
      public string FileName { get => FileName; set => FileName = value; }
      public string FilePath { get => FilePath; set => FilePath = value; }
      public string FileSize { get => FileSize; set => FileSize = value; }


      // Retention properties based on SOS Record Retention Schedules.
      public string RecordDescription { get => RecordDescription; set => RecordDescription = value; }
      public string YearStart { get => YearStart; set => YearStart = value; }
      public string YearEnd { get => YearEnd; set => YearEnd = value; }
      public string YearPublished { get => YearPublished; set => YearPublished = value; }


      // Fix these to reference "RecordSeries" types
      public string RecordSeries { get => RecordSeries; set => RecordSeries = value; }
      //public string RecordDAN { get => RecordDAN; set => RecordDAN = value; }
         // DAN = Diposition Authority Number


      // Authors should ultimately be stored as an array of Author objects in an XMP template
      public string Author { get => Author; set => Author = value; }
      #endregion Properties

      public Record(string format)
      {
         Format = format;
      }

      public Record()
      {
      //   this.FileName = string.Empty;
      //   this.FilePath = string.Empty;
      //   this.Author = string.Empty;
      //   this.FileSize = string.Empty;

      //   this.Title = string.Empty;
      //   this.RecordDescription = string.Empty;
      //   this.RecordSeries = string.Empty;
      //   //this.RecordDAN = string.Empty ;
      //   this.YearPublished = string.Empty ;
      //   this.YearStart = string.Empty ;
      //   this.YearEnd = string.Empty ;
      }


   }


}
