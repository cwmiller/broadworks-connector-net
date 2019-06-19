using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The sort criteria specifies the group common phone list number as the column for the sort, whether
    /// sort is ascending or descending, and whether the sort is case sensitive.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""58293b6da8bb02a6430b3eb1beb91194:412""}]")]
    public class SortByGroupCommonPhoneListNumber : BroadWorksConnector.Ocip.Models.SortCriteria
    {

    }
}
