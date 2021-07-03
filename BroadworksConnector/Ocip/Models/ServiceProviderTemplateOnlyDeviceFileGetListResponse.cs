using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderTemplateOnlyDeviceFileGetListRequest.
    /// Contains a list of template files used to support a Visual Device Management device.
    /// <see cref="ServiceProviderTemplateOnlyDeviceFileGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:6941""}]")]
    public class ServiceProviderTemplateOnlyDeviceFileGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<string> _templateFileUrl = new List<string>();

        [XmlElement(ElementName = "templateFileUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:6941")]
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
