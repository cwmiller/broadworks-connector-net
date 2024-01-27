using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserDirectedCallPickupWithBargeInGetRequest.
    /// <see cref="UserDirectedCallPickupWithBargeInGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:42945""}]")]
    public class UserDirectedCallPickupWithBargeInGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _enableBargeInWarningTone;

        [XmlElement(ElementName = "enableBargeInWarningTone", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:42945")]
        public bool EnableBargeInWarningTone
        {
            get => _enableBargeInWarningTone;
            set
            {
                EnableBargeInWarningToneSpecified = true;
                _enableBargeInWarningTone = value;
            }
        }

        [XmlIgnore]
        protected bool EnableBargeInWarningToneSpecified { get; set; }

    }
}
