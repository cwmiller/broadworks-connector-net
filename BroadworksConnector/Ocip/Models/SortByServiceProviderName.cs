using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The sort criteria specifies the service provider name as the column for
    /// the sort, whether the sort is ascending or descending, and whether the
    /// sort is case sensitive.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""58293b6da8bb02a6430b3eb1beb91194:591""}]")]
    public class SortByServiceProviderName : BroadWorksConnector.Ocip.Models.SortCriteria
    {

    }
}
