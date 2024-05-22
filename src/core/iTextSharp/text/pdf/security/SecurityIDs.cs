/*
    This file is part of the iText (R) project.
    Copyright (c) 1998-2022 iText Group NV
    Authors: iText Software.

    This program is free software; you can redistribute it and/or modify
    it under the terms of the GNU Affero General Public License version 3
    as published by the Free Software Foundation with the addition of the
    following permission added to Section 15 as permitted in Section 7(a):
    FOR ANY PART OF THE COVERED WORK IN WHICH THE COPYRIGHT IS OWNED BY
    ITEXT GROUP. ITEXT GROUP DISCLAIMS THE WARRANTY OF NON INFRINGEMENT
    OF THIRD PARTY RIGHTS
    
    This program is distributed in the hope that it will be useful, but
    WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
    or FITNESS FOR A PARTICULAR PURPOSE.
    See the GNU Affero General Public License for more details.
    You should have received a copy of the GNU Affero General Public License
    along with this program; if not, see http://www.gnu.org/licenses or write to
    the Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor,
    Boston, MA, 02110-1301 USA, or download the license from the following URL:
    http://itextpdf.com/terms-of-use/
    
    The interactive user interfaces in modified source and object code versions
    of this program must display Appropriate Legal Notices, as required under
    Section 5 of the GNU Affero General Public License.
    
    In accordance with Section 7(b) of the GNU Affero General Public License,
    a covered work must retain the producer line in every PDF that is created
    or manipulated using iText.
    
    You can be released from the requirements of the license by purchasing
    a commercial license. Buying such a license is mandatory as soon as you
    develop commercial activities involving the iText software without
    disclosing the source code of your own applications.
    These activities include: offering paid services to customers as an ASP,
    serving PDFs on the fly in a web application, shipping iText with a closed
    source product.
    
    For more information, please contact iText Software Corp. at this
    address: sales@itextpdf.com
 */
using Org.BouncyCastle.Asn1;
using System;
namespace iTextSharp.text.pdf.security {

    /**
     * A list of IDs that are used by the security classes
     */
    public class SecurityIDs {

	    public static readonly DerObjectIdentifier ID_PKCS7_DATA = new DerObjectIdentifier("1.2.840.113549.1.7.1");
	    public static readonly DerObjectIdentifier ID_PKCS7_SIGNED_DATA = new DerObjectIdentifier ("1.2.840.113549.1.7.2");
      public const String ID_RSA = "1.2.840.113549.1.1.1";
      public const String ID_DSA = "1.2.840.10040.4.1";
      public const String ID_ECDSA = "1.2.840.10045.2.1"; 
      public static readonly DerObjectIdentifier ID_CONTENT_TYPE = new DerObjectIdentifier ("1.2.840.113549.1.9.3");
	    public static readonly DerObjectIdentifier ID_MESSAGE_DIGEST = new DerObjectIdentifier ("1.2.840.113549.1.9.4");
	    public static readonly DerObjectIdentifier ID_SIGNING_TIME = new DerObjectIdentifier ("1.2.840.113549.1.9.5");
	    public static readonly DerObjectIdentifier ID_ADBE_REVOCATION = new DerObjectIdentifier ("1.2.840.113583.1.1.8");
	    public static readonly DerObjectIdentifier ID_TSA = new DerObjectIdentifier ("1.2.840.113583.1.1.9.1");
	    public static readonly DerObjectIdentifier ID_OCSP = new DerObjectIdentifier ("1.3.6.1.5.5.7.48.1");
      public static readonly DerObjectIdentifier ID_AA_SIGNING_CERTIFICATE_V1 = new DerObjectIdentifier("1.2.840.113549.1.9.16.2.12");
	    public static readonly DerObjectIdentifier ID_AA_SIGNING_CERTIFICATE_V2 = new DerObjectIdentifier ("1.2.840.113549.1.9.16.2.47");

    }
}
