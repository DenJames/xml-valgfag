﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Denne kode blev oprettet ved hjælp af et værktøj.
//     Runtime-version:4.0.30319.42000
//
//     Ændringer af denne fil kan resultere i ukorrekt funktion, og ændringerne mistes, hvis
//     koden oprettes igen.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class InvoiceExport {
    
    private string madeByField;
    
    private Club[] clubsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string MadeBy {
        get {
            return this.madeByField;
        }
        set {
            this.madeByField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Clubs", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public Club[] Clubs {
        get {
            return this.clubsField;
        }
        set {
            this.clubsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Club {
    
    private string nameField;
    
    private string addressField;
    
    private Member[] memberField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Address {
        get {
            return this.addressField;
        }
        set {
            this.addressField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Member", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public Member[] Member {
        get {
            return this.memberField;
        }
        set {
            this.memberField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Member {
    
    private string nameField;
    
    private string addressField;
    
    private Invoice[] invoiceField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Address {
        get {
            return this.addressField;
        }
        set {
            this.addressField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Invoice", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public Invoice[] Invoice {
        get {
            return this.invoiceField;
        }
        set {
            this.invoiceField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Invoice {
    
    private float totalAmountField;
    
    private InvoiceLine[] invoiceLineField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public float TotalAmount {
        get {
            return this.totalAmountField;
        }
        set {
            this.totalAmountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("InvoiceLine", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public InvoiceLine[] InvoiceLine {
        get {
            return this.invoiceLineField;
        }
        set {
            this.invoiceLineField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class InvoiceLine {
    
    private string productNameField;
    
    private string productDescriptionField;
    
    private float amountField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ProductName {
        get {
            return this.productNameField;
        }
        set {
            this.productNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ProductDescription {
        get {
            return this.productDescriptionField;
        }
        set {
            this.productDescriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public float Amount {
        get {
            return this.amountField;
        }
        set {
            this.amountField = value;
        }
    }
}
