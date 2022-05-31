using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemTemplateOnlyDeviceFileGetListRequest.
    /// Contains a list of template files used to support a Visual Device Management device.
    /// <see cref="SystemTemplateOnlyDeviceFileGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:18512""}]")]
    public class SystemTemplateOnlyDeviceFileGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<string> _templateFileUrl = new List<string>();

        [XmlElement(ElementName = "templateFileUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:18512")]
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
