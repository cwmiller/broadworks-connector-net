using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a call center's announcement settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// Replaced By: GroupCallCenterModifyAnnouncementRequest16
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="GroupCallCenterModifyAnnouncementRequest16"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:6644""}]")]
    public class GroupCallCenterModifyAnnouncementRequest14sp6 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:6644")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceUserIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementSelection _entranceMessageSelection;

        [XmlElement(ElementName = "entranceMessageSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6644")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementSelection EntranceMessageSelection
        {
            get => _entranceMessageSelection;
            set
            {
                EntranceMessageSelectionSpecified = true;
                _entranceMessageSelection = value;
            }
        }

        [XmlIgnore]
        protected bool EntranceMessageSelectionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.LabeledFileResource _entranceMessageAudioFile;

        [XmlElement(ElementName = "entranceMessageAudioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6644")]
        public BroadWorksConnector.Ocip.Models.LabeledFileResource EntranceMessageAudioFile
        {
            get => _entranceMessageAudioFile;
            set
            {
                EntranceMessageAudioFileSpecified = true;
                _entranceMessageAudioFile = value;
            }
        }

        [XmlIgnore]
        protected bool EntranceMessageAudioFileSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.LabeledFileResource _entranceMessageVideoFile;

        [XmlElement(ElementName = "entranceMessageVideoFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6644")]
        public BroadWorksConnector.Ocip.Models.LabeledFileResource EntranceMessageVideoFile
        {
            get => _entranceMessageVideoFile;
            set
            {
                EntranceMessageVideoFileSpecified = true;
                _entranceMessageVideoFile = value;
            }
        }

        [XmlIgnore]
        protected bool EntranceMessageVideoFileSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementSelection _periodicComfortMessageSelection;

        [XmlElement(ElementName = "periodicComfortMessageSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6644")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementSelection PeriodicComfortMessageSelection
        {
            get => _periodicComfortMessageSelection;
            set
            {
                PeriodicComfortMessageSelectionSpecified = true;
                _periodicComfortMessageSelection = value;
            }
        }

        [XmlIgnore]
        protected bool PeriodicComfortMessageSelectionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.LabeledFileResource _periodicComfortMessageAudioFile;

        [XmlElement(ElementName = "periodicComfortMessageAudioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6644")]
        public BroadWorksConnector.Ocip.Models.LabeledFileResource PeriodicComfortMessageAudioFile
        {
            get => _periodicComfortMessageAudioFile;
            set
            {
                PeriodicComfortMessageAudioFileSpecified = true;
                _periodicComfortMessageAudioFile = value;
            }
        }

        [XmlIgnore]
        protected bool PeriodicComfortMessageAudioFileSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.LabeledFileResource _periodicComfortMessageVideoFile;

        [XmlElement(ElementName = "periodicComfortMessageVideoFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6644")]
        public BroadWorksConnector.Ocip.Models.LabeledFileResource PeriodicComfortMessageVideoFile
        {
            get => _periodicComfortMessageVideoFile;
            set
            {
                PeriodicComfortMessageVideoFileSpecified = true;
                _periodicComfortMessageVideoFile = value;
            }
        }

        [XmlIgnore]
        protected bool PeriodicComfortMessageVideoFileSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterMusicOnHoldSourceModify _onHoldSource;

        [XmlElement(ElementName = "onHoldSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6644")]
        public BroadWorksConnector.Ocip.Models.CallCenterMusicOnHoldSourceModify OnHoldSource
        {
            get => _onHoldSource;
            set
            {
                OnHoldSourceSpecified = true;
                _onHoldSource = value;
            }
        }

        [XmlIgnore]
        protected bool OnHoldSourceSpecified { get; set; }

        protected bool _onHoldUseAlternateSourceForInternalCalls;

        [XmlElement(ElementName = "onHoldUseAlternateSourceForInternalCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6644")]
        public bool OnHoldUseAlternateSourceForInternalCalls
        {
            get => _onHoldUseAlternateSourceForInternalCalls;
            set
            {
                OnHoldUseAlternateSourceForInternalCallsSpecified = true;
                _onHoldUseAlternateSourceForInternalCalls = value;
            }
        }

        [XmlIgnore]
        protected bool OnHoldUseAlternateSourceForInternalCallsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterMusicOnHoldSourceModify _onHoldInternalSource;

        [XmlElement(ElementName = "onHoldInternalSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6644")]
        public BroadWorksConnector.Ocip.Models.CallCenterMusicOnHoldSourceModify OnHoldInternalSource
        {
            get => _onHoldInternalSource;
            set
            {
                OnHoldInternalSourceSpecified = true;
                _onHoldInternalSource = value;
            }
        }

        [XmlIgnore]
        protected bool OnHoldInternalSourceSpecified { get; set; }

    }
}
