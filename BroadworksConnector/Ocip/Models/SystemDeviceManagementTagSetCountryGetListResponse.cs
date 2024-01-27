using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemDeviceManagementTagSetCountryGetListRequest.
    /// The response includes the list of countries defined in a region of a specified tag set.
    /// <see cref="SystemDeviceManagementTagSetCountryGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:8260""}]")]
    public class SystemDeviceManagementTagSetCountryGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<string> _countryName = new List<string>();

        [XmlElement(ElementName = "countryName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:8260")]
        [Length(3)]
        [RegularExpression(@"[A-Z][A-Z][A-Z]")]
        public List<string> CountryName
        {
            get => _countryName;
            set
            {
                CountryNameSpecified = true;
                _countryName = value;
            }
        }

        [XmlIgnore]
        protected bool CountryNameSpecified { get; set; }

    }
}
