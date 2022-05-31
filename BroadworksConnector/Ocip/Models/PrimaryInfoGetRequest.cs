using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests information about the primary server for high-availability support.
    /// The response is either a PrimaryInfoGetResponse or an ErrorResponse.
    /// <see cref="PrimaryInfoGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6b27fcc79475236456fc113a42b75543:440""}]")]
    public class PrimaryInfoGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.PrimaryInfoGetResponse>
    {

        protected bool _isPrivate;

        [XmlElement(ElementName = "isPrivate", IsNullable = false, Namespace = "")]
        [Group(@"6b27fcc79475236456fc113a42b75543:440")]
        public bool IsPrivate
        {
            get => _isPrivate;
            set
            {
                IsPrivateSpecified = true;
                _isPrivate = value;
            }
        }

        [XmlIgnore]
        protected bool IsPrivateSpecified { get; set; }

        protected bool _isAddressInfoRequested;

        [XmlElement(ElementName = "isAddressInfoRequested", IsNullable = false, Namespace = "")]
        [Group(@"6b27fcc79475236456fc113a42b75543:440")]
        public bool IsAddressInfoRequested
        {
            get => _isAddressInfoRequested;
            set
            {
                IsAddressInfoRequestedSpecified = true;
                _isAddressInfoRequested = value;
            }
        }

        [XmlIgnore]
        protected bool IsAddressInfoRequestedSpecified { get; set; }

    }
}
