﻿using cosmos.ibase.v1beta1;
using terra.market.v1beta1;

namespace Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.staking.v1beta1
{

    [global::ProtoBuf.ProtoContract()]
    public partial class HistoricalInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"header")]
        public Header Header { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"valset")]
        public global::System.Collections.Generic.List<Validator> Valsets { get; } = new global::System.Collections.Generic.List<Validator>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Header : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CommissionRates : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"rate")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Rate { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"max_rate")]
        [global::System.ComponentModel.DefaultValue("")]
        public string MaxRate { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"max_change_rate")]
        [global::System.ComponentModel.DefaultValue("")]
        public string MaxChangeRate { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Commission : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"commission_rates")]
        public CommissionRates CommissionRates { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"update_time", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        public global::System.DateTime? UpdateTime { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Description : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"moniker")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Moniker { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"identity")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Identity { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"website")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Website { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"security_contact")]
        [global::System.ComponentModel.DefaultValue("")]
        public string SecurityContact { get; set; } = "";

        [global::ProtoBuf.ProtoMember(5, Name = @"details")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Details { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Validator : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"operator_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string OperatorAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"consensus_pubkey")]
        public global::Google.Protobuf.WellKnownTypes.Any ConsensusPubkey { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"jailed")]
        public bool Jailed { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"status")]
        public BondStatus Status { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"tokens")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Tokens { get; set; } = "";

        [global::ProtoBuf.ProtoMember(6, Name = @"delegator_shares")]
        [global::System.ComponentModel.DefaultValue("")]
        public string DelegatorShares { get; set; } = "";

        [global::ProtoBuf.ProtoMember(7, Name = @"description")]
        public Description Description { get; set; }

        [global::ProtoBuf.ProtoMember(8, Name = @"unbonding_height")]
        public long UnbondingHeight { get; set; }

        [global::ProtoBuf.ProtoMember(9, Name = @"unbonding_time", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        public global::System.DateTime? UnbondingTime { get; set; }

        [global::ProtoBuf.ProtoMember(10, Name = @"commission")]
        public Commission Commission { get; set; }

        [global::ProtoBuf.ProtoMember(11, Name = @"min_self_delegation")]
        [global::System.ComponentModel.DefaultValue("")]
        public string MinSelfDelegation { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ValAddresses : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"addresses")]
        public global::System.Collections.Generic.List<string> Addresses { get; } = new global::System.Collections.Generic.List<string>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class DVPair : global::ProtoBuf.IExtensible
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

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class DVPairs : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"pairs")]
        public global::System.Collections.Generic.List<DVPair> Pairs { get; } = new global::System.Collections.Generic.List<DVPair>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class DVVTriplet : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"delegator_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string DelegatorAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"validator_src_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ValidatorSrcAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"validator_dst_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ValidatorDstAddress { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class DVVTriplets : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"triplets")]
        public global::System.Collections.Generic.List<DVVTriplet> Triplets { get; } = new global::System.Collections.Generic.List<DVVTriplet>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Delegation : global::ProtoBuf.IExtensible
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

        [global::ProtoBuf.ProtoMember(3, Name = @"shares")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Shares { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class UnbondingDelegation : global::ProtoBuf.IExtensible
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

        [global::ProtoBuf.ProtoMember(3, Name = @"entries")]
        public global::System.Collections.Generic.List<UnbondingDelegationEntry> Entries { get; set; } = new global::System.Collections.Generic.List<UnbondingDelegationEntry>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class UnbondingDelegationEntry : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"creation_height")]
        public long CreationHeight { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"completion_time", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        public global::System.DateTime? CompletionTime { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"initial_balance")]
        [global::System.ComponentModel.DefaultValue("")]
        public string InitialBalance { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"balance")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Balance { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class RedelegationEntry : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"creation_height")]
        public long CreationHeight { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"completion_time", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        public global::System.DateTime? CompletionTime { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"initial_balance")]
        [global::System.ComponentModel.DefaultValue("")]
        public string InitialBalance { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"shares_dst")]
        [global::System.ComponentModel.DefaultValue("")]
        public string SharesDst { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Redelegation : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"delegator_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string DelegatorAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"validator_src_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ValidatorSrcAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"validator_dst_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ValidatorDstAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"entries")]
        public global::System.Collections.Generic.List<RedelegationEntry> Entries { get; set; } = new global::System.Collections.Generic.List<RedelegationEntry>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Params : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"unbonding_time", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        public global::System.TimeSpan? UnbondingTime { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"max_validators")]
        public uint MaxValidators { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"max_entries")]
        public uint MaxEntries { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"historical_entries")]
        public uint HistoricalEntries { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"bond_denom")]
        [global::System.ComponentModel.DefaultValue("")]
        public string BondDenom { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class DelegationResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"delegation")]
        public Delegation Delegation { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"balance")]
        public Coin Balance { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class RedelegationEntryResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"redelegation_entry")]
        public RedelegationEntry RedelegationEntry { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"balance")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Balance { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class RedelegationResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"redelegation")]
        public Redelegation Redelegation { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"entries")]
        public global::System.Collections.Generic.List<RedelegationEntryResponse> Entries { get; } = new global::System.Collections.Generic.List<RedelegationEntryResponse>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Pool : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"not_bonded_tokens")]
        [global::System.ComponentModel.DefaultValue("")]
        public string NotBondedTokens { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"bonded_tokens")]
        [global::System.ComponentModel.DefaultValue("")]
        public string BondedTokens { get; set; } = "";
    }

    [global::ProtoBuf.ProtoContract()]
    public enum BondStatus
    {
        [global::ProtoBuf.ProtoEnum(Name = @"BOND_STATUS_UNSPECIFIED")]
        BondStatusUnspecified = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"BOND_STATUS_UNBONDED")]
        BondStatusUnbonded = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"BOND_STATUS_UNBONDING")]
        BondStatusUnbonding = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"BOND_STATUS_BONDED")]
        BondStatusBonded = 3,
    }
}
