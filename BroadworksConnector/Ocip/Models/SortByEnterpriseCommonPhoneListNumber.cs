using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""846fcf536fcb4b0f0d32e089e99e4bfc:347""}]")]
    public class SortByEnterpriseCommonPhoneListNumber : BroadWorksConnector.Ocip.Models.SortCriteria
    {

    }
}
