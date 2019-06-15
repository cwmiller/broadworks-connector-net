using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The sort criteria specifies the file size as the column for the sort,
    /// whether the sort is ascending or descending, and whether the sort is
    /// case sensitive.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SortByAnnouncementFileSize : BroadWorksConnector.Ocip.Models.SortCriteriaNumeric
    {

        
    }
}
