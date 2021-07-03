using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ResellerGetRequest.
    /// 
    /// Replaced by: ResellerGetResponse22
    /// <see cref="ResellerGetRequest"/>
    /// <see cref="ResellerGetResponse22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:16548""}]")]
    public class ResellerGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _resellerName;

        [XmlElement(ElementName = "resellerName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:16548")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ResellerName
        {
            get => _resellerName;
            set
            {
                ResellerNameSpecified = true;
                _resellerName = value;
            }
        }

        [XmlIgnore]
        protected bool ResellerNameSpecified { get; set; }

    }
}
