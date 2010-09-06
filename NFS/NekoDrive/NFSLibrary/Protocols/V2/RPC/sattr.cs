/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
using org.acplt.oncrpc;

public class sattr : XdrAble {
    public int mode;
    public int uid;
    public int gid;
    public int size;
    public nfstimeval atime;
    public nfstimeval mtime;

    public sattr() {
    }

    public sattr(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        xdr.xdrEncodeInt(mode);
        xdr.xdrEncodeInt(uid);
        xdr.xdrEncodeInt(gid);
        xdr.xdrEncodeInt(size);
        atime.xdrEncode(xdr);
        mtime.xdrEncode(xdr);
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        mode = xdr.xdrDecodeInt();
        uid = xdr.xdrDecodeInt();
        gid = xdr.xdrDecodeInt();
        size = xdr.xdrDecodeInt();
        atime = new nfstimeval(xdr);
        mtime = new nfstimeval(xdr);
    }

}
// End of sattr.cs