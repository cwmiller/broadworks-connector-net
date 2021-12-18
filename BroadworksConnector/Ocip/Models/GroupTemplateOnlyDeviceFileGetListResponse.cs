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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:8399""}]")]
    public class GroupTemplateOnlyDeviceFileGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<string> _templateFileUrl = new List<string>();

        [XmlElement(ElementName = "templateFileUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8399")]
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
