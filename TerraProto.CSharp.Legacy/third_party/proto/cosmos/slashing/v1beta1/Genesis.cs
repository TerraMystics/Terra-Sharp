﻿namespace Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.slashing.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class GenesisState : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"params")]
        public Params Params { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"signing_infos")]
        public global::System.Collections.Generic.List<SigningInfo> SigningInfos { get; } = new global::System.Collections.Generic.List<SigningInfo>();

        [global::ProtoBuf.ProtoMember(3, Name = @"missed_blocks")]
        public global::System.Collections.Generic.List<ValidatorMissedBlocks> MissedBlocks { get; } = new global::System.Collections.Generic.List<ValidatorMissedBlocks>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class SigningInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Address { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"validator_signing_info")]
        public ValidatorSigningInfo ValidatorSigningInfo { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ValidatorMissedBlocks : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Address { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"missed_blocks")]
        public global::System.Collections.Generic.List<MissedBlock> MissedBlocks { get; } = new global::System.Collections.Generic.List<MissedBlock>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MissedBlock : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"index")]
        public long Index { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"missed")]
        public bool Missed { get; set; }

    }
}
