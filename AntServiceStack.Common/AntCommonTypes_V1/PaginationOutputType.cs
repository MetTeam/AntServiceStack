﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1026
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AntServiceStack.Common.Types
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Runtime.Serialization;
    using System.Collections.Generic;
    using AntServiceStack.ProtoBuf;
    using AntServiceStack.ServiceHost;
    using AntServiceStack.Baiji.Specific;
    using System.Linq;
    
    
    /// <summary>
    /// Shows the pagination data for the item search. Child elements include the
    /// page number returned, the maximum entries returned per page, the total number
    /// of pages that can be returned, and the total number of items that match the
    /// search criteria.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1026")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace= "http://soa.ant.com/common/types/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace= "http://soa.ant.com/common/types/v1", IsNullable=true)]
    [DataContract(Namespace= "http://soa.ant.com/common/types/v1")]
    [ProtoContract()]
    public partial class PaginationOutputType : ISpecificRecord
    {
        
        private int pageNumberField;
        
        private int entriesPerPageField;
        
        private int totalPagesField;
        
        private int totalEntriesField;
        
        public static readonly AntServiceStack.Baiji.Schema.Schema SCHEMA = AntServiceStack.Baiji.Schema.Schema.Parse((("{\"type\":\"record\",\"name\":\"PaginationOutputType\",\"namespace\":\"" + typeof(PaginationOutputType).Namespace) 
                        + "\",\"doc\":null,\"fields\":[{\"name\":\"PageNumber\",\"type\":\"int\"},{\"name\":\"EntriesPerPage" +
                            "\",\"type\":\"int\"},{\"name\":\"TotalPages\",\"type\":\"int\"},{\"name\":\"TotalEntries\",\"type\"" +
                            ":\"int\"}]}"));

        /// <summary>
        /// The subset of item data returned in the current response. Search results
        /// are divided into sets, or "pages," of item data. The number of pages is
        /// equal to the total number of items matching the search criteria divided
        /// by the value specified for entriesPerPage in the request. The response
        /// for a request contains one "page" of item data.
        /// <br> <br>
        /// This returned value indicates the page number of item data returned (a
        /// subset of the complete result set). If this field contains 1, the
        /// response contains the first page of item data (the default). If the value
        /// returned in totalEntries is less than the value for entriesPerPage,
        /// pageNumber returns 1 and the response contains the entire result set.
        /// <br> <br>
        /// The value of pageNumber is normally equal to the value input for
        /// paginationInput.pageNumber. However, if the number input for pageNumber
        /// is greater than the total possible pages of output, ant returns the last
        /// page of item data in the result set, and the value for pageNumber is set
        /// to the respective (last) page number.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int PageNumber
        {
            get
            {
                return this.pageNumberField;
            }
            set
            {
                this.pageNumberField = value;
            }
        }
        
        /// <summary>
        /// The maximum number of items that can be returned in the response. This
        /// number is always equal to the value input for
        /// paginationInput.entriesPerPage.
        /// <br> <br>
        /// The end of the result set has been reached if the number specified for
        /// entriesPerPage is greater than the number of items found on the specified
        /// pageNumber. In this case, there will be fewer items returned than the
        /// number specified in entriesPerPage. This can be determined by comparing
        /// the entriesPerPage value with the value returned in the count attribute
        /// for the searchResult field.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int EntriesPerPage
        {
            get
            {
                return this.entriesPerPageField;
            }
            set
            {
                this.entriesPerPageField = value;
            }
        }
        
        /// <summary>
        /// The total number of pages of data that could be returned by repeated
        /// search requests. Note that if you modify the value of
        /// inputPagination.entriesPerPage in a request, the value output for
        /// totalPages will change. A value of "0" is returned if service does not find
        /// any items that match the search criteria.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int TotalPages
        {
            get
            {
                return this.totalPagesField;
            }
            set
            {
                this.totalPagesField = value;
            }
        }
        
        /// <summary>
        /// The total number of items found that match the search criteria in your
        /// request. Depending on the input value for entriesPerPage, the response
        /// might include only a portion (a page) of the entire result set. A value
        /// of "0" is returned if service does not find any items that match the search
        /// criteria.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public int TotalEntries
        {
            get
            {
                return this.totalEntriesField;
            }
            set
            {
                this.totalEntriesField = value;
            }
        }
        
        public virtual AntServiceStack.Baiji.Schema.Schema GetSchema()
        {
            return SCHEMA;
        }
        
        public virtual object Get(int fieldPos)
        {
            switch(fieldPos)
            {
                case 0: return this.PageNumber;
                case 1: return this.EntriesPerPage;
                case 2: return this.TotalPages;
                case 3: return this.TotalEntries;
                default: throw new AntServiceStack.Baiji.Exceptions.BaijiRuntimeException("Bad index " + fieldPos + " in Get()");
            }
        }
        
        public virtual void Put(int fieldPos, object fieldValue)
        {
            switch(fieldPos)
            {
                case 0: this.PageNumber = (int)fieldValue; break;
                case 1: this.EntriesPerPage = (int)fieldValue; break;
                case 2: this.TotalPages = (int)fieldValue; break;
                case 3: this.TotalEntries = (int)fieldValue; break;
                default: throw new AntServiceStack.Baiji.Exceptions.BaijiRuntimeException("Bad index " + fieldPos + " in Put()");
            }
        }
        
        public virtual object Get(string fieldName)
        {
            var recordSchema = GetSchema() as AntServiceStack.Baiji.Schema.RecordSchema;
            if (recordSchema == null)
            {
                return null;
            }
            AntServiceStack.Baiji.Schema.Field field;
            if (!recordSchema.TryGetField(fieldName, out field))
            {
                return null;
            }
            return Get(field.Pos);
        }
        
        public virtual void Put(string fieldName, object fieldValue)
        {
            var recordSchema = GetSchema() as AntServiceStack.Baiji.Schema.RecordSchema;
            if (recordSchema == null)
            {
                return ;
            }
            AntServiceStack.Baiji.Schema.Field field;
            if (!recordSchema.TryGetField(fieldName, out field))
            {
                return ;
            }
            Put(field.Pos, fieldValue);
        }
    }
}
