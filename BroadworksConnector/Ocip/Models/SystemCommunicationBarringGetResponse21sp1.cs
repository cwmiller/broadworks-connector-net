using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCommunicationBarringGetRequest21sp1.
    /// The following elements are only used in AS data mode:
    /// vmCallbackScreening, value "false" is returned in XS data mode.
    /// <see cref="SystemCommunicationBarringGetRequest21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:6167""}]")]
    public class SystemCommunicationBarringGetResponse21sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _directTransferScreening;

        [XmlElement(ElementName = "directTransferScreening", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:6167")]
        public bool DirectTransferScreening
        {
            get => _directTransferScreening;
            set
            {
                DirectTransferScreeningSpecified = true;
                _directTransferScreening = value;
            }
        }

        [XmlIgnore]
        protected bool DirectTransferScreeningSpecified { get; set; }

        protected bool _vmCallbackScreening;

        [XmlElement(ElementName = "vmCallbackScreening", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:6167")]
        public bool VmCallbackScreening
        {
            get => _vmCallbackScreening;
            set
            {
                VmCallbackScreeningSpecified = true;
                _vmCallbackScreening = value;
            }
        }

        [XmlIgnore]
        protected bool VmCallbackScreeningSpecified { get; set; }

    }
}
