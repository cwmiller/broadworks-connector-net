using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupMWIDeliveryToMobileEndpointCustomTemplateGetRequest23.
    /// <see cref="GroupMWIDeliveryToMobileEndpointCustomTemplateGetRequest23"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1ea80c1e18c25d0eed23dbc7bd18f1dc:118""}]")]
    public class GroupMWIDeliveryToMobileEndpointCustomTemplateGetResponse23 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isEnabled;

        [XmlElement(ElementName = "isEnabled", IsNullable = false, Namespace = "")]
        [Group(@"1ea80c1e18c25d0eed23dbc7bd18f1dc:118")]
        public bool IsEnabled
        {
            get => _isEnabled;
            set
            {
                IsEnabledSpecified = true;
                _isEnabled = value;
            }
        }

        [XmlIgnore]
        protected bool IsEnabledSpecified { get; set; }

        protected string _monthAbbreviations;

        [XmlElement(ElementName = "monthAbbreviations", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1ea80c1e18c25d0eed23dbc7bd18f1dc:118")]
        [MinLength(1)]
        [MaxLength(128)]
        public string MonthAbbreviations
        {
            get => _monthAbbreviations;
            set
            {
                MonthAbbreviationsSpecified = (value != null);
                _monthAbbreviations = value;
            }
        }

        [XmlIgnore]
        protected bool MonthAbbreviationsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateBody23 _templateBody;

        [XmlElement(ElementName = "templateBody", IsNullable = false, Namespace = "")]
        [Group(@"1ea80c1e18c25d0eed23dbc7bd18f1dc:118")]
        public BroadWorksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateBody23 TemplateBody
        {
            get => _templateBody;
            set
            {
                TemplateBodySpecified = true;
                _templateBody = value;
            }
        }

        [XmlIgnore]
        protected bool TemplateBodySpecified { get; set; }

    }
}
