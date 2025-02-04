﻿using cosmos.ibase.v1beta1;
using terra.market.v1beta1;

namespace Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.distribution.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class DelegatorWithdrawInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"delegator_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string DelegatorAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"withdraw_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string WithdrawAddress { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ValidatorOutstandingRewardsRecord : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"validator_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ValidatorAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"outstanding_rewards")]
        public global::System.Collections.Generic.List<DecCoin> OutstandingRewards { get; } = new global::System.Collections.Generic.List<DecCoin>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ValidatorAccumulatedCommissionRecord : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"validator_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ValidatorAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"accumulated")]
        public ValidatorAccumulatedCommission Accumulated { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ValidatorHistoricalRewardsRecord : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"validator_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ValidatorAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"period")]
        public ulong Period { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"rewards")]
        public ValidatorHistoricalRewards Rewards { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ValidatorCurrentRewardsRecord : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"validator_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ValidatorAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"rewards")]
        public ValidatorCurrentRewards Rewards { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class DelegatorStartingInfoRecord : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"delegator_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string DelegatorAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"validator_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ValidatorAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"starting_info")]
        public DelegatorStartingInfo StartingInfo { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ValidatorSlashEventRecord : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"validator_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ValidatorAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"height")]
        public ulong Height { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"period")]
        public ulong Period { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"validator_slash_event")]
        public ValidatorSlashEvent ValidatorSlashEvent { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GenesisState : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"params")]
        public Params Params { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"fee_pool")]
        public FeePool FeePool { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"delegator_withdraw_infos")]
        public global::System.Collections.Generic.List<DelegatorWithdrawInfo> DelegatorWithdrawInfos { get; } = new global::System.Collections.Generic.List<DelegatorWithdrawInfo>();

        [global::ProtoBuf.ProtoMember(4, Name = @"previous_proposer")]
        [global::System.ComponentModel.DefaultValue("")]
        public string PreviousProposer { get; set; } = "";

        [global::ProtoBuf.ProtoMember(5, Name = @"outstanding_rewards")]
        public global::System.Collections.Generic.List<ValidatorOutstandingRewardsRecord> OutstandingRewards { get; } = new global::System.Collections.Generic.List<ValidatorOutstandingRewardsRecord>();

        [global::ProtoBuf.ProtoMember(6, Name = @"validator_accumulated_commissions")]
        public global::System.Collections.Generic.List<ValidatorAccumulatedCommissionRecord> ValidatorAccumulatedCommissions { get; } = new global::System.Collections.Generic.List<ValidatorAccumulatedCommissionRecord>();

        [global::ProtoBuf.ProtoMember(7, Name = @"validator_historical_rewards")]
        public global::System.Collections.Generic.List<ValidatorHistoricalRewardsRecord> ValidatorHistoricalRewards { get; } = new global::System.Collections.Generic.List<ValidatorHistoricalRewardsRecord>();

        [global::ProtoBuf.ProtoMember(8, Name = @"validator_current_rewards")]
        public global::System.Collections.Generic.List<ValidatorCurrentRewardsRecord> ValidatorCurrentRewards { get; } = new global::System.Collections.Generic.List<ValidatorCurrentRewardsRecord>();

        [global::ProtoBuf.ProtoMember(9, Name = @"delegator_starting_infos")]
        public global::System.Collections.Generic.List<DelegatorStartingInfoRecord> DelegatorStartingInfos { get; } = new global::System.Collections.Generic.List<DelegatorStartingInfoRecord>();

        [global::ProtoBuf.ProtoMember(10, Name = @"validator_slash_events")]
        public global::System.Collections.Generic.List<ValidatorSlashEventRecord> ValidatorSlashEvents { get; } = new global::System.Collections.Generic.List<ValidatorSlashEventRecord>();

    }
}
