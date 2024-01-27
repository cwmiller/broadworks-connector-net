using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ServiceProviderHPBXAlternateCarrierSelectionGetRequest.
    /// <see cref="ServiceProviderHPBXAlternateCarrierSelectionGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:4709""}]")]
    public class ServiceProviderHPBXAlternateCarrierSelectionGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _processCbcCarrierSelection;

        [XmlElement(ElementName = "processCbcCarrierSelection", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:4709")]
        public bool ProcessCbcCarrierSelection
        {
            get => _processCbcCarrierSelection;
            set
            {
                ProcessCbcCarrierSelectionSpecified = true;
                _processCbcCarrierSelection = value;
            }
        }

        [XmlIgnore]
        protected bool ProcessCbcCarrierSelectionSpecified { get; set; }

        protected string _preselectedLocalCarrier;

        [XmlElement(ElementName = "preselectedLocalCarrier", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:4709")]
        [MinLength(1)]
        [MaxLength(80)]
        public string PreselectedLocalCarrier
        {
            get => _preselectedLocalCarrier;
            set
            {
                PreselectedLocalCarrierSpecified = true;
                _preselectedLocalCarrier = value;
            }
        }

        [XmlIgnore]
        protected bool PreselectedLocalCarrierSpecified { get; set; }

        protected string _preselectedDistantCarrier;

        [XmlElement(ElementName = "preselectedDistantCarrier", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:4709")]
        [MinLength(1)]
        [MaxLength(80)]
        public string PreselectedDistantCarrier
        {
            get => _preselectedDistantCarrier;
            set
            {
                PreselectedDistantCarrierSpecified = true;
                _preselectedDistantCarrier = value;
            }
        }

        [XmlIgnore]
        protected bool PreselectedDistantCarrierSpecified { get; set; }

    }
}
