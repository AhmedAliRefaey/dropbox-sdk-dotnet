// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>The download error object</para>
    /// </summary>
    public class DownloadError : enc.IEncodable<DownloadError>
    {
        /// <summary>
        /// <para>Initializes a new instance of the DownloadError class.</para>
        /// </summary>
        public DownloadError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Disallowed</para>
        /// </summary>
        public bool IsDisallowed
        {
            get
            {
                return this is Disallowed;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Disallowed, or <c>null</c>.</para>
        /// </summary>
        public Disallowed AsDisallowed
        {
            get
            {
                return this as Disallowed;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is NoFile</para>
        /// </summary>
        public bool IsNoFile
        {
            get
            {
                return this is NoFile;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a NoFile, or <c>null</c>.</para>
        /// </summary>
        public NoFile AsNoFile
        {
            get
            {
                return this as NoFile;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region IEncodable<DownloadError> methods

        /// <summary>
        /// <para>Encodes the object using the supplied encoder.</para>
        /// </summary>
        /// <param name="encoder">The encoder being used to serialize the object.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void enc.IEncodable<DownloadError>.Encode(enc.IEncoder encoder)
        {
            if (this.IsDisallowed)
            {
                ((enc.IEncodable<Disallowed>)this).Encode(encoder);
            }
            else if (this.IsNoFile)
            {
                ((enc.IEncodable<NoFile>)this).Encode(encoder);
            }
            else
            {
                ((enc.IEncodable<Other>)this).Encode(encoder);
            }
        }

        /// <summary>
        /// <para>Decodes on object using the supplied decoder.</para>
        /// </summary>
        /// <param name="decoder">The decoder used to deserialize the object.</param>
        /// <returns>The deserialized object. Note: this is not necessarily the current
        /// instance.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        DownloadError enc.IEncodable<DownloadError>.Decode(enc.IDecoder decoder)
        {
            switch (decoder.GetUnionName())
            {
            case "disallowed":
                using (var obj = decoder.GetObject())
                {
                    return new Disallowed(obj.GetFieldObject<Dropbox.Api.Files.Disallowed>("disallowed"));
                }
            case "no_file":
                using (var obj = decoder.GetObject())
                {
                    return new NoFile(obj.GetFieldObject<Dropbox.Api.Files.NoFile>("no_file"));
                }
            default:
                return Other.Instance;
            }
        }

        #endregion

        /// <summary>
        /// <para>The disallowed object</para>
        /// </summary>
        public sealed class Disallowed : DownloadError, enc.IEncodable<Disallowed>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Disallowed" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public Disallowed(Dropbox.Api.Files.Disallowed value)
            {
                this.Value = value;
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public Dropbox.Api.Files.Disallowed Value { get; private set; }

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            void enc.IEncodable<Disallowed>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField("disallowed", this.Value);
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            Disallowed enc.IEncodable<Disallowed>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>The no file object</para>
        /// </summary>
        public sealed class NoFile : DownloadError, enc.IEncodable<NoFile>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NoFile" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public NoFile(Dropbox.Api.Files.NoFile value)
            {
                this.Value = value;
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public Dropbox.Api.Files.NoFile Value { get; private set; }

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            void enc.IEncodable<NoFile>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField("no_file", this.Value);
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            NoFile enc.IEncodable<NoFile>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : DownloadError, enc.IEncodable<Other>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<Other>.Encode(enc.IEncoder encoder)
            {
                encoder.AddUnion("other");
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            Other enc.IEncodable<Other>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }
    }
}
