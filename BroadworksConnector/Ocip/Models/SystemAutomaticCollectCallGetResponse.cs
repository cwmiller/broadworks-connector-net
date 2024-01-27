using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemAutomaticCollectCallGetRequest.
    /// Returns system Automatic Collect Call service settings.
    /// 
    /// Replaced by SystemAutomaticCollectCallGetResponse22 in AS mode.
    /// <see cref="SystemAutomaticCollectCallGetRequest"/>
    /// <see cref="SystemAutomaticCollectCallGetResponse22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:20753""}]")]
    public class SystemAutomaticCollectCallGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _enableAutomaticCollectCall;

        [XmlElement(ElementName = "enableAutomaticCollectCall", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:20753")]
        public bool EnableAutomaticCollectCall
        {
            get => _enableAutomaticCollectCall;
            set
            {
                EnableAutomaticCollectCallSpecified = true;
                _enableAutomaticCollectCall = value;
            }
        }

        [XmlIgnore]
        protected bool EnableAutomaticCollectCallSpecified { get; set; }

        protected bool _enableConnectTone;

        [XmlElement(ElementName = "enableConnectTone", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:20753")]
        public bool EnableConnectTone
        {
            get => _enableConnectTone;
            set
            {
                EnableConnectToneSpecified = true;
                _enableConnectTone = value;
            }
        }

        [XmlIgnore]
        protected bool EnableConnectToneSpecified { get; set; }

    }
}
