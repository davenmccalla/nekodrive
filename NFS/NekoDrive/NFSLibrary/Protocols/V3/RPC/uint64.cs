/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
using org.acplt.oncrpc;

public class uint64 : XdrAble {

    public long value;

    public uint64() {
    }

    public uint64(long value) {
        this.value = value;
    }

    public uint64(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        xdr.xdrEncodeLong(value);
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        value = xdr.xdrDecodeLong();
    }

}
// End of uint64.cs