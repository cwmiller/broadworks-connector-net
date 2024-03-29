using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Abstract base type for specifying search criteria where the search criteria params are OR'ed.
    /// A search criteria is an optional element
    /// used to restrict the number of rows returned when requesting a potentially large set of
    /// data from the provisioning server.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SearchCriteriaComposedOrDnExtension))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SearchCriteriaComposedOrUserName))]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""972fbf832439609ec8f2765c5637c3f1:366""}]")]
    public abstract class SearchCriteriaComposedOr
    {

    }
}
