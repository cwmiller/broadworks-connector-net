using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemNumberFormattingParametersGetRequest.
    /// Contains the system number formatting parameter.
    /// <see cref="SystemNumberFormattingParametersGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:13009""}]")]
    public class SystemNumberFormattingParametersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _applyFormattingToE164Numbers;

        [XmlElement(ElementName = "applyFormattingToE164Numbers", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:13009")]
        public bool ApplyFormattingToE164Numbers
        {
            get => _applyFormattingToE164Numbers;
            set
            {
                ApplyFormattingToE164NumbersSpecified = true;
                _applyFormattingToE164Numbers = value;
            }
        }

        [XmlIgnore]
        protected bool ApplyFormattingToE164NumbersSpecified { get; set; }

    }
}
