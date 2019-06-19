using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserAccessDeviceFileGetRequest.
    /// <see cref="UserAccessDeviceFileGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:185""}]")]
    public class UserAccessDeviceFileGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _templateUrl;

        [XmlElement(ElementName = "templateUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:185")]
        [MinLength(1)]
        [MaxLength(256)]
        public string TemplateUrl
        {
            get => _templateUrl;
            set
            {
                TemplateUrlSpecified = true;
                _templateUrl = value;
            }
        }

        [XmlIgnore]
        public bool TemplateUrlSpecified { get; set; }

    }
}
