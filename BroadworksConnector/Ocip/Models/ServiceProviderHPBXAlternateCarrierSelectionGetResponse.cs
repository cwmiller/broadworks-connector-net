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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:3840""}]")]
    public class ServiceProviderHPBXAlternateCarrierSelectionGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _processCbcCarrierSelection;

        [XmlElement(ElementName = "processCbcCarrierSelection", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:3840")]
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

        private string _preselectedLocalCarrier;

        [XmlElement(ElementName = "preselectedLocalCarrier", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:3840")]
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

        private string _preselectedDistantCarrier;

        [XmlElement(ElementName = "preselectedDistantCarrier", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:3840")]
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
