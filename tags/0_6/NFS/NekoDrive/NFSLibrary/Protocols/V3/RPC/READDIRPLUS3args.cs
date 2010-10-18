/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
using org.acplt.oncrpc;

public class READDIRPLUS3args : XdrAble {
    public nfs_fh3 dir;
    public cookie3 cookie;
    public cookieverf3 cookieverf;
    public count3 dircount;
    public count3 maxcount;

    public READDIRPLUS3args() {
    }

    public READDIRPLUS3args(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        dir.xdrEncode(xdr);
        cookie.xdrEncode(xdr);
        cookieverf.xdrEncode(xdr);
        dircount.xdrEncode(xdr);
        maxcount.xdrEncode(xdr);
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        dir = new nfs_fh3(xdr);
        cookie = new cookie3(xdr);
        cookieverf = new cookieverf3(xdr);
        dircount = new count3(xdr);
        maxcount = new count3(xdr);
    }

}
// End of READDIRPLUS3args.cs