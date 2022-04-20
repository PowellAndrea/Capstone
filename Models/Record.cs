#region Comments
/*
 * Andrea Powell 
 * Centralia College Capstone Project
 * Record Class
 * 
 * 
 *    should I create a new class pdfRecord : Record and add the PdfDocument and PdfDocumentInfo objects to that class?
 *    
 *    Look at public strings - use private with getters/setters?
 *    Add Cutoff Date to retention metadata, 
 *       is there an XMP template targeted to archivists?  
 *       Maybe the Library of Congress
 */
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata_Manager
{
   public class Record
   {
      #region Class Properties
      // issues with internal and private strings - get/set revisit later

      /// Record object uuid
      internal Guid FileId;
      /// PDF Internal version ID  xmpMM:InstanceID
      public string PdfInstanceId;

      public string FilePath;
      public string FileName;
      public string FileSize;  // System managed

      /// Dublin Core 1.1 Namespace (DCMI)
      /// https://developer.adobe.com/xmp/docs/XMPNamespaces/dc/
      public string Title;       //dc:title
      public string Author;      //dc:creator
      public string Description; //dc:description

      /// Pdfx 1.3 namespace - Custom Metdata
      public string RecordSeries;   //pdfx:RecordSeries
      public string YearStart;      //pdfx:YearStart  - change this to use DCMI span?
      public string YearEnd;        //pdfx:YearEnd
      public string Published;      //pdfx:Published - change this to use DCMI

      /// XMP Rights Management namespace --  //xmpRights:Marked = False  for Public Records
      public string CopyrightNotice;      //xmpRights:Marked = False

      #endregion

      public Record()
      {
         FileId = new Guid();
         //PdfInstanceId = string.Empty; // PDF Internal version ID - needs review  xmpMM:InstanceID
         FilePath = string.Empty;
         FileName = string.Empty;
         FileSize = string.Empty;  // System managed

         // Dublin Core 1.1 Namespace
         Title = string.Empty;      //dc:title
         Author = string.Empty;      //dc:creator
         Description = string.Empty;   //dc:description
         YearStart = string.Empty;     //pdfx:YearStart
         YearEnd = string.Empty;       //pdfx:YearEnd
         Published = string.Empty;     //pdfx:Published - change this to use DCMI
         RecordSeries = string.Empty;  //pdfx:RecordSeries

      }
   }
}
