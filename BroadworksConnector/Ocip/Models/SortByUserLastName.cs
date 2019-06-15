using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The sort criteria specifies the user last name as the column for the sort, whether the
    /// sort is ascending or descending, and whether the sort is case sensitive.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SortByUserLastName : BroadWorksConnector.Ocip.Models.SortCriteria
    {

        
    }
}
