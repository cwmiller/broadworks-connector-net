using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupTemplateOnlyDeviceFileGetListRequest.
    /// Contains a list of template files used to support a Visual Device Management device.
    /// <see cref="GroupTemplateOnlyDeviceFileGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:8147""}]")]
    public class GroupTemplateOnlyDeviceFileGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<string> _templateFileUrl = new List<string>();

        [XmlElement(ElementName = "templateFileUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:8147")]
        [MinLength(1)]
        [MaxLength(256)]
        public List<string> TemplateFileUrl
        {
            get => _templateFileUrl;
            set
            {
                TemplateFileUrlSpecified = true;
                _templateFileUrl = value;
            }
        }

        [XmlIgnore]
        protected bool TemplateFileUrlSpecified { get; set; }

    }
}
