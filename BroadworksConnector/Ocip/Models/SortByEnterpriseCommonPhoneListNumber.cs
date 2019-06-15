using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The sort criteria specifies the enterprise common phone list number as as the column
    /// for the sort, whether sort is ascending or descending, and whether the sort is
    /// case sensitive.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SortByEnterpriseCommonPhoneListNumber : BroadWorksConnector.Ocip.Models.SortCriteria
    {

        
    }
}
