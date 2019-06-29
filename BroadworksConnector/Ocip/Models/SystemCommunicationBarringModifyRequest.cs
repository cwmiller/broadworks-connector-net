using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system level data associated with Communication Barring.
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// vmCallbackScreening
    /// 
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:5892""}]")]
    public class SystemCommunicationBarringModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _directTransferScreening;

        [XmlElement(ElementName = "directTransferScreening", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5892")]
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

        private bool _vmCallbackScreening;

        [XmlElement(ElementName = "vmCallbackScreening", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5892")]
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
