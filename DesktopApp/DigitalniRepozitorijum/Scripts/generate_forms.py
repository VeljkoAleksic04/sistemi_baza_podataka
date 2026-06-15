#!/usr/bin/env python3
"""AI skripta Generise Windows Forms fajlove za DigitalniRepozitorijum projekat."""
import os
from pathlib import Path

ROOT = Path(__file__).resolve().parent.parent
FORME = ROOT / "Forme"

RESX = """<?xml version="1.0" encoding="utf-8"?>
<root>
  <xsd:schema id="root" xmlns="" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:msdata="urn:schemas-microsoft-com:xml-msdata">
    <xsd:import namespace="http://www.w3.org/XML/1998/namespace" />
    <xsd:element name="root" msdata:IsDataSet="true">
      <xsd:complexType>
        <xsd:choice maxOccurs="unbounded">
          <xsd:element name="metadata">
            <xsd:complexType>
              <xsd:sequence>
                <xsd:element name="value" type="xsd:string" minOccurs="0" />
              </xsd:sequence>
              <xsd:attribute name="name" use="required" type="xsd:string" />
              <xsd:attribute name="type" type="xsd:string" />
              <xsd:attribute name="mimetype" type="xsd:string" />
              <xsd:attribute ref="xml:space" />
            </xsd:complexType>
          </xsd:element>
          <xsd:element name="assembly">
            <xsd:complexType>
              <xsd:sequence>
                <xsd:element name="alias" type="xsd:string" minOccurs="0" />
                <xsd:element name="name" type="xsd:string" minOccurs="0" />
              </xsd:sequence>
            </xsd:complexType>
          </xsd:element>
          <xsd:element name="data">
            <xsd:complexType>
              <xsd:sequence>
                <xsd:element name="value" type="xsd:string" minOccurs="0" msdata:Ordinal="1" />
                <xsd:element name="comment" type="xsd:string" minOccurs="0" msdata:Ordinal="2" />
              </xsd:sequence>
              <xsd:attribute name="name" type="xsd:string" use="required" />
              <xsd:attribute name="type" type="xsd:string" />
              <xsd:attribute name="mimetype" type="xsd:string" />
              <xsd:attribute ref="xml:space" />
            </xsd:complexType>
          </xsd:element>
          <xsd:element name="resheader">
            <xsd:complexType>
              <xsd:sequence>
                <xsd:element name="value" type="xsd:string" minOccurs="0" msdata:Ordinal="1" />
              </xsd:sequence>
              <xsd:attribute name="name" type="xsd:string" use="required" />
            </xsd:complexType>
          </xsd:element>
        </xsd:choice>
      </xsd:complexType>
    </xsd:element>
  </xsd:schema>
  <resheader name="resmimetype"><value>text/microsoft-resx</value></resheader>
  <resheader name="version"><value>2.0</value></resheader>
  <resheader name="reader"><value>System.Resources.ResXResourceReader, System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089</value></resheader>
  <resheader name="writer"><value>System.Resources.ResXResourceWriter, System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089</value></resheader>
</root>
"""


def write_resx(name: str):
    path = FORME / f"{name}.resx"
    if not path.exists():
        path.write_text(RESX, encoding="utf-8")


def list_designer(name: str, title: str, group_text: str, columns: list[str], buttons: list[dict], width=980, height=580):
    btn_fields = []
    btn_init = []
    btn_add = []
    y = 12
    for b in buttons:
        if b.get("label_only"):
            lbl = b["label_field"]
            btn_fields.append(f"        private System.Windows.Forms.Label {lbl};")
            btn_init.append(f"""            this.{lbl} = new System.Windows.Forms.Label();
            this.{lbl}.AutoSize = true;
            this.{lbl}.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.{lbl}.Location = new System.Drawing.Point(720, {y});
            this.{lbl}.Name = "{lbl}";
            this.{lbl}.Size = new System.Drawing.Size(200, 13);
            this.{lbl}.TabIndex = 100;
            this.{lbl}.Text = "{b['label']}";""")
            btn_add.append(f"            this.Controls.Add(this.{lbl});")
            y += 22
            continue

        field = b["field"]
        btn_fields.append(f"        private System.Windows.Forms.Button {field};")
        if "label" in b:
            lbl = b["label_field"]
            btn_fields.append(f"        private System.Windows.Forms.Label {lbl};")
            btn_init.append(f"""            this.{lbl} = new System.Windows.Forms.Label();
            this.{lbl}.AutoSize = true;
            this.{lbl}.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.{lbl}.Location = new System.Drawing.Point(720, {y});
            this.{lbl}.Name = "{lbl}";
            this.{lbl}.Size = new System.Drawing.Size(200, 13);
            this.{lbl}.TabIndex = 100;
            this.{lbl}.Text = "{b['label']}";""")
            btn_add.append(f"            this.Controls.Add(this.{lbl});")
            y += 22
        btn_init.append(f"""            this.{field} = new System.Windows.Forms.Button();
            this.{field}.Location = new System.Drawing.Point(720, {y});
            this.{field}.Name = "{field}";
            this.{field}.Size = new System.Drawing.Size(240, 32);
            this.{field}.TabIndex = 10;
            this.{field}.Text = "{b['text']}";
            this.{field}.UseVisualStyleBackColor = true;
            this.{field}.Click += new System.EventHandler(this.{field}_Click);""")
        btn_add.append(f"            this.Controls.Add(this.{field});")
        y += 38

    col_init = []
    for i, col in enumerate(columns):
        col_init.append(f"""            this.col{col} = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col{col}.HeaderText = "{col}";
            this.col{col}.Name = "col{col}";
            this.col{col}.DataPropertyName = "{col}";""")

    col_fields = [f"        private System.Windows.Forms.DataGridViewTextBoxColumn col{c};" for c in columns]
    col_array = ", ".join(f"this.col{c}" for c in columns)

    return f"""namespace DigitalniRepozitorijum.Forme
{{
    partial class {name}
    {{
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {{
            if (disposing && (components != null))
            {{
                components.Dispose();
            }}
            base.Dispose(disposing);
        }}

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {{
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
{chr(10).join('            ' + line for line in col_init)}
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // groupBox
            this.groupBox.Controls.Add(this.dataGridView);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(690, 556);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "{group_text}";
            // dataGridView
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {{
                {col_array}
            }});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 19);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(684, 534);
            this.dataGridView.TabIndex = 0;
{chr(10).join(btn_init)}
            // {name}
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size({width}, {height});
            this.Controls.Add(this.groupBox);
{chr(10).join(btn_add)}
            this.Name = "{name}";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "{title}";
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }}

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.DataGridView dataGridView;
{chr(10).join(col_fields)}
{chr(10).join(btn_fields)}
    }}
}}
"""


def list_cs(name: str, parent_param: str | None, buttons: list[dict]):
    parent_field = f"        private readonly int? _{parent_param};\n" if parent_param else ""
    if parent_param:
        btn_names = ', '.join(b['field'] for b in buttons if not b.get('label_only'))
        ctor = f"""        public {name}(int? {parent_param} = null)
        {{
            _{parent_param} = {parent_param};
            InitializeComponent();
            FormStilovi.PrimeniStilListe(this, groupBox, {btn_names});
        }}"""
    else:
        btn_names = ', '.join(b['field'] for b in buttons if not b.get('label_only'))
        ctor = f"""        public {name}()
        {{
            InitializeComponent();
            FormStilovi.PrimeniStilListe(this, groupBox, {btn_names});
        }}"""

    methods = []
    for b in buttons:
        if b.get("label_only"):
            continue
        field = b["field"]
        if b.get("action") == "delete":
            methods.append(f"""        private void {field}_Click(object sender, EventArgs e)
        {{
            if (GetSelectedId() == null) return;
            var result = MessageBox.Show("Da li ste sigurni da zelite da obrisete izabrani zapis?", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {{
                MessageBox.Show("Brisanje ce biti implementirano kroz NHibernate.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }}
        }}""")
        elif "target" in b:
            target = b["target"]
            if b.get("pass_parent") and parent_param and b.get("needs_selection"):
                open_line = f"var id = GetSelectedId(); if (id == null) return; using var form = new {target}(_{parent_param});"
            elif b.get("pass_parent") and parent_param:
                open_line = f"using var form = new {target}(_{parent_param});"
            elif b.get("needs_selection"):
                if target.startswith("Izmeni"):
                    open_line = f"var id = GetSelectedId(); if (id == null) return; using var form = new {target}(id: id.Value);"
                else:
                    open_line = f"var id = GetSelectedId(); if (id == null) return; using var form = new {target}(id.Value);"
            else:
                open_line = f"using var form = new {target}();"
            methods.append(f"""        private void {field}_Click(object sender, EventArgs e)
        {{
            {open_line}
            form.ShowDialog();
        }}""")

    get_selected = """
        private int? GetSelectedId()
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite red iz tabele.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            return Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
        }
"""

    return f"""using System;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{{
    public partial class {name} : Form
    {{
{parent_field}
{ctor}
{get_selected}
{chr(10).join(methods)}
    }}
}}
"""


def input_designer(name: str, title: str, fields: list[tuple[str, str]], width=420, height=None):
    height = height or (80 + len(fields) * 35 + 60)
    ctrl_fields = []
    init = []
    adds = []
    y = 20
    for field_name, label_text in fields:
        lbl = f"lbl{field_name}"
        txt = f"txt{field_name}"
        ctrl_fields.append(f"        private System.Windows.Forms.Label {lbl};")
        ctrl_fields.append(f"        private System.Windows.Forms.TextBox {txt};")
        init.append(f"""            this.{lbl} = new System.Windows.Forms.Label();
            this.{lbl}.AutoSize = true;
            this.{lbl}.Location = new System.Drawing.Point(20, {y});
            this.{lbl}.Name = "{lbl}";
            this.{lbl}.Size = new System.Drawing.Size(120, 15);
            this.{lbl}.TabIndex = 0;
            this.{lbl}.Text = "{label_text}:";
            this.{txt} = new System.Windows.Forms.TextBox();
            this.{txt}.Location = new System.Drawing.Point(160, {y - 3});
            this.{txt}.Name = "{txt}";
            this.{txt}.Size = new System.Drawing.Size(230, 23);
            this.{txt}.TabIndex = 1;""")
        adds.extend([f"this.{lbl}", f"this.{txt}"])
        y += 35

    init.append("""            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.btnPotvrdi.Location = new System.Drawing.Point(160, """ + str(y + 10) + """);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(110, 32);
            this.btnPotvrdi.TabIndex = 50;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnOdustani.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOdustani.Location = new System.Drawing.Point(280, """ + str(y + 10) + """);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(110, 32);
            this.btnOdustani.TabIndex = 51;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;""")

    return f"""namespace DigitalniRepozitorijum.Forme
{{
    partial class {name}
    {{
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {{
            if (disposing && (components != null))
            {{
                components.Dispose();
            }}
            base.Dispose(disposing);
        }}

        private void InitializeComponent()
        {{
            this.SuspendLayout();
{chr(10).join(init)}
            this.AcceptButton = this.btnPotvrdi;
            this.CancelButton = this.btnOdustani;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size({width}, {height});
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPotvrdi);
{chr(10).join('            this.Controls.Add(' + c + ');' for c in adds)}
            this.Name = "{name}";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "{title}";
            this.ResumeLayout(false);
            this.PerformLayout();
        }}

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
{chr(10).join(ctrl_fields)}
    }}
}}
"""


def input_cs(name: str, parent_param: str | None = None, entity_id: bool = False):
    fields = []
    if parent_param:
        fields.append(f"        private readonly int? _{parent_param};")
    if entity_id or name.startswith("Izmeni"):
        fields.append("        private readonly int? _id;")

    params = []
    if parent_param:
        params.append(f"int? {parent_param} = null")
    if entity_id or name.startswith("Izmeni"):
        params.append("int? id = null")
    param_str = ", ".join(params)

    body = []
    if parent_param:
        body.append(f"            _{parent_param} = {parent_param};")
    if entity_id or name.startswith("Izmeni"):
        body.append("            _id = id;")
    body.append("            InitializeComponent();")
    body.append("            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);")

    if param_str:
        ctor = f"""        public {name}({param_str})
        {{
{chr(10).join(body)}
        }}"""
    else:
        ctor = f"""        public {name}()
        {{
{chr(10).join(body)}
        }}"""

    return f"""using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{{
    public partial class {name} : Form
    {{
{chr(10).join(fields)}

{ctor}

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {{
            MessageBox.Show("Cuvanje ce biti implementirano kroz NHibernate.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }}
    }}
}}
"""


def gen_list(name, title, group, columns, buttons, parent_param=None, w=980, h=580):
    write_resx(name)
    (FORME / f"{name}.Designer.cs").write_text(list_designer(name, title, group, columns, buttons, w, h), encoding="utf-8")
    (FORME / f"{name}.cs").write_text(list_cs(name, parent_param, buttons), encoding="utf-8")


def gen_input(name, title, fields, parent_param=None, h=None):
    write_resx(name)
    (FORME / f"{name}.Designer.cs").write_text(input_designer(name, title, fields, height=h), encoding="utf-8")
    (FORME / f"{name}.cs").write_text(input_cs(name, parent_param), encoding="utf-8")


CRUD = [
    {"field": "btnDodaj", "text": "Dodaj", "target": None},
    {"field": "btnIzmeni", "text": "Izmeni", "needs_selection": True, "target": None},
    {"field": "btnObrisi", "text": "Obrisi", "action": "delete"},
]

# --- MAIN FORMS ---
gen_list("PublikacijeForm", "LISTA PUBLIKACIJA", "Lista publikacija",
         ["Id", "Naslov", "Jezik", "DatumObjavljivanja", "Status", "Vidljivost"],
         [
             {"field": "btnDodaj", "text": "Dodaj publikaciju", "target": "DodajPublikacijuForm"},
             {"field": "btnIzmeni", "text": "Izmeni publikaciju", "needs_selection": True, "target": "IzmeniPublikacijuForm"},
             {"field": "btnObrisi", "text": "Obrisi publikaciju", "action": "delete"},
             {"label_only": True, "label_field": "lblPovezano", "label": "Povezani podaci"},
             {"field": "btnAutori", "text": "Autori publikacije", "needs_selection": True, "target": "AutoriPublikacijeForm"},
             {"field": "btnVerzije", "text": "Verzije publikacije", "needs_selection": True, "target": "VerzijePublikacijeForm"},
             {"field": "btnKljucneReci", "text": "Ključne reci", "needs_selection": True, "target": "KljucneReciPublikacijeForm"},
             {"field": "btnCitati", "text": "Citati", "needs_selection": True, "target": "CitatiPublikacijeForm"},
             {"field": "btnPovezane", "text": "Povezane publikacije", "needs_selection": True, "target": "PovezanePublikacijeForm"},
             {"label_only": True, "label_field": "lblTipovi", "label": "Tipovi publikacije"},
             {"field": "btnNaucniRadovi", "text": "Naučni radovi", "target": "NaucniRadoviForm"},
             {"field": "btnKnjige", "text": "Knjige", "target": "KnjigeForm"},
             {"field": "btnPoglavlja", "text": "Poglavlja u knjizi", "target": "PoglavljaUKnjiziForm"},
             {"field": "btnDoktorske", "text": "Doktorske disertacije", "target": "DoktorskeDisertacijeForm"},
             {"field": "btnDatasetovi", "text": "Datasetovi", "target": "DatasetoviForm"},
             {"field": "btnSoftverski", "text": "Softverski artefakti", "target": "SoftverskiArtefaktiForm"},
             {"field": "btnObrazovni", "text": "Obrazovni materijali", "target": "ObrazovniMaterijaliForm"},
             {"field": "btnPrezentacije", "text": "Prezentacije", "target": "PrezentacijeForm"},
             {"field": "btnTehnicki", "text": "Tehnicki izvestaji", "target": "TehnickiIzvestajiForm"},
         ], h=720)

gen_list("IstrazivaciForm", "LISTA ISTRAZIVACA", "Lista istrazivaca",
         ["Id", "Ime", "Prezime", "Drzava", "NaucnoZvanje", "NaucnaOblast", "StatusNaloga"],
         [
             {"field": "btnDodaj", "text": "Dodaj istrazivaca", "target": "DodajIstrazivacaForm"},
             {"field": "btnIzmeni", "text": "Izmeni istrazivaca", "needs_selection": True, "target": "IzmeniIstrazivacaForm"},
             {"field": "btnObrisi", "text": "Obrisi istrazivaca", "action": "delete"},
             {"label_only": True, "label_field": "lblPovezano", "label": "Povezani podaci"},
             {"field": "btnTelefoni", "text": "Telefoni", "needs_selection": True, "target": "TelefoniIstrazivacaForm"},
             {"field": "btnEmail", "text": "Email adrese", "needs_selection": True, "target": "EmailAdreseIstrazivacaForm"},
             {"field": "btnAngazovanja", "text": "Angazovanja", "needs_selection": True, "target": "AngazovanjaIstrazivacaForm"},
             {"field": "btnPublikacije", "text": "Publikacije autora", "needs_selection": True, "target": "PublikacijeAutoraForm"},
         ])

gen_list("InstitucijeForm", "LISTA INSTITUCIJA", "Lista institucija",
         ["Id", "Naziv", "Adresa"],
         [
             {"field": "btnDodaj", "text": "Dodaj instituciju", "target": "DodajInstitucijuForm"},
             {"field": "btnIzmeni", "text": "Izmeni instituciju", "needs_selection": True, "target": "IzmeniInstitucijuForm"},
             {"field": "btnObrisi", "text": "Obrisi instituciju", "action": "delete"},
             {"label_only": True, "label_field": "lblPovezano", "label": "Povezani podaci"},
             {"field": "btnKontaktTelefoni", "text": "Kontakt telefoni", "needs_selection": True, "target": "KontaktTelefoniInstitucijeForm"},
             {"field": "btnKontaktMailovi", "text": "Kontakt mailovi", "needs_selection": True, "target": "KontaktMailoviInstitucijeForm"},
             {"field": "btnNaucneOblasti", "text": "Naucne oblasti", "needs_selection": True, "target": "NaucneOblastiInstitucijeForm"},
             {"field": "btnZaposleni", "text": "Zaposleni istrazivaci", "needs_selection": True, "target": "ZaposleniIstrazivaciForm"},
         ])

# --- PUBLICATION SUBTYPES ---
subtypes = [
    ("NaucniRadoviForm", "NAUČNI RADOVI", "Naučni radovi", ["Id", "Naslov", "DOI", "TipRada", "Stranice", "Izvor"],
     "DodajNaucniRadForm", "IzmeniNaucniRadForm", None),
    ("KnjigeForm", "KNJIGE", "Knjige", ["Id", "Naslov", "Izdavac", "MestoIzdanja"],
     "DodajKnjiguForm", "IzmeniKnjiguForm", "UredniciKnjigeForm"),
    ("PoglavljaUKnjiziForm", "POGLAVLJA U KNJIZI", "Poglavlja u knjizi", ["Id", "Naslov", "Izdavac", "MestoIzdanja"],
     "DodajPoglavljeUKnjiziForm", "IzmeniPoglavljeUKnjiziForm", "UredniciPoglavljaForm"),
    ("DoktorskeDisertacijeForm", "DOKTORSKE DISERTACIJE", "Doktorske disertacije", ["Id", "Naslov", "Status"],
     "DodajDoktorskuDisertacijuForm", "IzmeniDoktorskuDisertacijuForm", None),
    ("DatasetoviForm", "DATASETOVI", "Datasetovi", ["Id", "Naslov", "Format", "BrojZapisa", "Velicina"],
     "DodajDatasetForm", "IzmeniDatasetForm", None),
    ("SoftverskiArtefaktiForm", "SOFTVERSKI ARTEFAKTI", "Softverski artefakti", ["Id", "Naslov", "ProgramskiJezik", "NacinLicenciranja"],
     "DodajSoftverskiArtefaktForm", "IzmeniSoftverskiArtefaktForm", "PodrzanePlatformeForm"),
    ("ObrazovniMaterijaliForm", "OBRAZOVNI MATERIJALI", "Obrazovni materijali", ["Id", "Naslov", "Jezik", "Status"],
     "DodajObrazovniMaterijalForm", "IzmeniObrazovniMaterijalForm", None),
    ("PrezentacijeForm", "PREZENTACIJE", "Prezentacije", ["Id", "Naslov", "DatumObjavljivanja"],
     "DodajPrezentacijuForm", "IzmeniPrezentacijuForm", None),
    ("TehnickiIzvestajiForm", "TEHNICKI IZVESTAJI", "Tehnicki izvestaji", ["Id", "Naslov", "Status"],
     "DodajTehnickiIzvestajForm", "IzmeniTehnickiIzvestajForm", None),
]

for sn, title, group, cols, dodaj, izmeni, extra in subtypes:
    btns = [
        {"field": "btnDodaj", "text": f"Dodaj", "target": dodaj},
        {"field": "btnIzmeni", "text": f"Izmeni", "needs_selection": True, "target": izmeni},
        {"field": "btnObrisi", "text": f"Obrisi", "action": "delete"},
    ]
    if extra:
        btns.append({"field": "btnExtra", "text": extra.replace("Form", "").replace("Urednici", "Urednici").replace("PodrzanePlatforme", "Podrzane platforme"),
                     "needs_selection": True, "target": extra})
        if extra == "UredniciKnjigeForm":
            btns[-1]["text"] = "Urednici knjige"
        elif extra == "UredniciPoglavljaForm":
            btns[-1]["text"] = "Urednici poglavlja"
        elif extra == "PodrzanePlatformeForm":
            btns[-1]["text"] = "Podrzane platforme"
    gen_list(sn, title, group, cols, btns)

# --- RELATED LIST FORMS ---
related = [
    ("AutoriPublikacijeForm", "AUTORI PUBLIKACIJE", "Autori publikacije", "idPublikacije",
     ["IdAutora", "Ime", "Prezime", "Redosled", "TipDoprinosa", "Uloga"],
     "DodajAutoraPublikacijeForm", "IzmeniAutoraPublikacijeForm"),
    ("VerzijePublikacijeForm", "VERZIJE PUBLIKACIJE", "Verzije publikacije", "idPublikacije",
     ["IdVerzije", "BrojVerzije", "DatumPostavljanja", "OpisIzmene", "OdgovornaOsoba"],
     "DodajVerzijuForm", "IzmeniVerzijuForm"),
    ("KljucneReciPublikacijeForm", "KLJUČNE REČI", "Ključne reci publikacije", "idPublikacije",
     ["Id", "KljucnaRec"],
     "DodajKljucnuRecForm", "IzmeniKljucnuRecForm"),
    ("CitatiPublikacijeForm", "CITATI", "Citati publikacije", "idPublikacije",
     ["IdCitata", "NaslovCitata", "TipCitata", "MestoCitiranja"],
     "DodajCitatForm", "IzmeniCitatForm"),
    ("PovezanePublikacijeForm", "POVEZANE PUBLIKACIJE", "Povezane publikacije", "idPublikacije",
     ["IdPublikacije2", "Naslov", "TipPovezanosti"],
     "DodajPovezanuPublikacijuForm", "IzmeniPovezanuPublikacijuForm"),
    ("TelefoniIstrazivacaForm", "TELEFONI ISTRAZIVACA", "Telefoni istrazivaca", "idIstrazivaca",
     ["Id", "Telefon"],
     "DodajTelefonIstrazivacaForm", "IzmeniTelefonIstrazivacaForm"),
    ("EmailAdreseIstrazivacaForm", "EMAIL ADRESE", "Email adrese istrazivaca", "idIstrazivaca",
     ["Id", "Email"],
     "DodajEmailIstrazivacaForm", "IzmeniEmailIstrazivacaForm"),
    ("AngazovanjaIstrazivacaForm", "ANGAZOVANJA", "Angazovanja istrazivaca", "idIstrazivaca",
     ["IdInstitucije", "NazivInstitucije", "OrganizacionaJedinica", "TipAngazovanja", "NazivPozicije", "DatumPocetka", "DatumZavrsetka"],
     "DodajAngazovanjeForm", "IzmeniAngazovanjeForm"),
    ("PublikacijeAutoraForm", "PUBLIKACIJE AUTORA", "Publikacije autora", "idAutora",
     ["IdPublikacije", "Naslov", "Redosled", "TipDoprinosa", "Uloga"],
     "DodajAutorstvoForm", "IzmeniAutorstvoForm"),
    ("KontaktTelefoniInstitucijeForm", "KONTAKT TELEFONI", "Kontakt telefoni institucije", "idInstitucije",
     ["Id", "KontaktTel"],
     "DodajKontaktTelefonForm", "IzmeniKontaktTelefonForm"),
    ("KontaktMailoviInstitucijeForm", "KONTAKT MAILOVI", "Kontakt mailovi institucije", "idInstitucije",
     ["Id", "KontaktMail"],
     "DodajKontaktMailForm", "IzmeniKontaktMailForm"),
    ("NaucneOblastiInstitucijeForm", "NAUČNE OBLASTI", "Naucne oblasti institucije", "idInstitucije",
     ["Id", "NaucnaOblast"],
     "DodajNaucnuOblastForm", "IzmeniNaucnuOblastForm"),
    ("ZaposleniIstrazivaciForm", "ZAPOSLENI ISTRAZIVACI", "Zaposleni istrazivaci", "idInstitucije",
     ["IdIstrazivaca", "Ime", "Prezime", "TipAngazovanja", "NazivPozicije", "DatumPocetka"],
     "DodajAngazovanjeInstitucijeForm", "IzmeniAngazovanjeInstitucijeForm"),
    ("PodrzanePlatformeForm", "PODRŽANE PLATFORME", "Podrzane platforme", "idPublikacije",
     ["Id", "PodrzanaPlatforma"],
     "DodajPodrzanuPlatformuForm", "IzmeniPodrzanuPlatformuForm"),
    ("UredniciKnjigeForm", "UREDNICI KNJIGE", "Urednici knjige", "idPublikacije",
     ["Id", "Urednik"],
     "DodajUrednikaKnjigeForm", "IzmeniUrednikaKnjigeForm"),
    ("UredniciPoglavljaForm", "UREDNICI POGLAVLJA", "Urednici poglavlja", "idPublikacije",
     ["Id", "Urednik"],
     "DodajUrednikaPoglavljaForm", "IzmeniUrednikaPoglavljaForm"),
]

for rn, title, group, parent, cols, dodaj, izmeni in related:
    btns = [
        {"field": "btnDodaj", "text": "Dodaj", "target": dodaj, "pass_parent": True},
        {"field": "btnIzmeni", "text": "Izmeni", "needs_selection": True, "target": izmeni, "pass_parent": True},
        {"field": "btnObrisi", "text": "Obrisi", "action": "delete"},
    ]
    gen_list(rn, title, group, cols, btns, parent_param=parent)

# --- ADD/EDIT MAIN ENTITIES ---
gen_input("DodajPublikacijuForm", "Dodaj publikaciju",
          [("Naslov", "Naslov"), ("Apstrakt", "Apstrakt"), ("Jezik", "Jezik"),
           ("DatumObjavljivanja", "Datum objavljivanja"), ("DatumKreiranja", "Datum kreiranja"),
           ("Status", "Status"), ("Vidljivost", "Vidljivost")], h=320)
gen_input("IzmeniPublikacijuForm", "Izmeni publikaciju",
          [("Naslov", "Naslov"), ("Apstrakt", "Apstrakt"), ("Jezik", "Jezik"),
           ("DatumObjavljivanja", "Datum objavljivanja"), ("Status", "Status"), ("Vidljivost", "Vidljivost")], h=290)

gen_input("DodajIstrazivacaForm", "Dodaj istrazivaca",
          [("Ime", "Ime"), ("Prezime", "Prezime"), ("DatumRodjenja", "Datum rodjenja"),
           ("Drzava", "Drzava"), ("StatusNaloga", "Status naloga"), ("NaucnoZvanje", "Naucno zvanje"),
           ("NaucnaOblast", "Naucna oblast"), ("ORCID", "ORCID")], h=350)
gen_input("IzmeniIstrazivacaForm", "Izmeni istrazivaca",
          [("Ime", "Ime"), ("Prezime", "Prezime"), ("DatumRodjenja", "Datum rodjenja"),
           ("Drzava", "Drzava"), ("StatusNaloga", "Status naloga"), ("NaucnoZvanje", "Naucno zvanje"),
           ("NaucnaOblast", "Naucna oblast"), ("ORCID", "ORCID")], h=350)

gen_input("DodajInstitucijuForm", "Dodaj instituciju",
          [("Naziv", "Naziv"), ("Adresa", "Adresa")], h=180)
gen_input("IzmeniInstitucijuForm", "Izmeni instituciju",
          [("Naziv", "Naziv"), ("Adresa", "Adresa")], h=180)

# --- ADD/EDIT SUBTYPES ---
subtype_inputs = [
    ("DodajNaucniRadForm", "Dodaj naučni rad", [("Naslov", "Naslov"), ("DOI", "DOI"), ("TipRada", "Tip rada"), ("Stranice", "Stranice"), ("Izvor", "Izvor")]),
    ("IzmeniNaucniRadForm", "Izmeni naučni rad", [("Naslov", "Naslov"), ("DOI", "DOI"), ("TipRada", "Tip rada"), ("Stranice", "Stranice"), ("Izvor", "Izvor")]),
    ("DodajKnjiguForm", "Dodaj knjigu", [("Naslov", "Naslov"), ("Izdavac", "Izdavac"), ("MestoIzdanja", "Mesto izdanja"), ("Jezik", "Jezik")]),
    ("IzmeniKnjiguForm", "Izmeni knjigu", [("Naslov", "Naslov"), ("Izdavac", "Izdavac"), ("MestoIzdanja", "Mesto izdanja"), ("Jezik", "Jezik")]),
    ("DodajPoglavljeUKnjiziForm", "Dodaj poglavlje", [("Naslov", "Naslov"), ("Izdavac", "Izdavac"), ("MestoIzdanja", "Mesto izdanja")]),
    ("IzmeniPoglavljeUKnjiziForm", "Izmeni poglavlje", [("Naslov", "Naslov"), ("Izdavac", "Izdavac"), ("MestoIzdanja", "Mesto izdanja")]),
    ("DodajDoktorskuDisertacijuForm", "Dodaj doktorsku", [("Naslov", "Naslov"), ("Apstrakt", "Apstrakt"), ("Jezik", "Jezik")]),
    ("IzmeniDoktorskuDisertacijuForm", "Izmeni doktorsku", [("Naslov", "Naslov"), ("Apstrakt", "Apstrakt"), ("Jezik", "Jezik")]),
    ("DodajDatasetForm", "Dodaj dataset", [("Naslov", "Naslov"), ("Format", "Format"), ("BrojZapisa", "Broj zapisa"), ("Velicina", "Velicina"), ("Licenca", "Licenca")]),
    ("IzmeniDatasetForm", "Izmeni dataset", [("Naslov", "Naslov"), ("Format", "Format"), ("BrojZapisa", "Broj zapisa"), ("Velicina", "Velicina"), ("Licenca", "Licenca")]),
    ("DodajSoftverskiArtefaktForm", "Dodaj softverski artefakt", [("Naslov", "Naslov"), ("ProgramskiJezik", "Programski jezik"), ("Link", "Link ka repozitorijumu"), ("Licenca", "Nacin licenciranja")]),
    ("IzmeniSoftverskiArtefaktForm", "Izmeni softverski artefakt", [("Naslov", "Naslov"), ("ProgramskiJezik", "Programski jezik"), ("Link", "Link ka repozitorijumu"), ("Licenca", "Nacin licenciranja")]),
    ("DodajObrazovniMaterijalForm", "Dodaj obrazovni materijal", [("Naslov", "Naslov"), ("Jezik", "Jezik")]),
    ("IzmeniObrazovniMaterijalForm", "Izmeni obrazovni materijal", [("Naslov", "Naslov"), ("Jezik", "Jezik")]),
    ("DodajPrezentacijuForm", "Dodaj prezentaciju", [("Naslov", "Naslov"), ("Datum", "Datum objavljivanja")]),
    ("IzmeniPrezentacijuForm", "Izmeni prezentaciju", [("Naslov", "Naslov"), ("Datum", "Datum objavljivanja")]),
    ("DodajTehnickiIzvestajForm", "Dodaj tehnicki izvestaj", [("Naslov", "Naslov"), ("Apstrakt", "Apstrakt")]),
    ("IzmeniTehnickiIzvestajForm", "Izmeni tehnicki izvestaj", [("Naslov", "Naslov"), ("Apstrakt", "Apstrakt")]),
]
for n, t, f in subtype_inputs:
    gen_input(n, t, f)

# --- ADD/EDIT RELATIONSHIP / MULTIVALUED ---
relation_inputs = [
    ("DodajAutoraPublikacijeForm", "Dodaj autora", "idPublikacije", [("Autor", "Autor"), ("Redosled", "Redosled"), ("TipDoprinosa", "Tip doprinosa"), ("Uloga", "Uloga")]),
    ("IzmeniAutoraPublikacijeForm", "Izmeni autora", "idPublikacije", [("Redosled", "Redosled"), ("TipDoprinosa", "Tip doprinosa"), ("Uloga", "Uloga")]),
    ("DodajVerzijuForm", "Dodaj verziju", "idPublikacije", [("BrojVerzije", "Broj verzije"), ("DatumPostavljanja", "Datum"), ("OpisIzmene", "Opis izmene"), ("OdgovornaOsoba", "Odgovorna osoba")]),
    ("IzmeniVerzijuForm", "Izmeni verziju", "idPublikacije", [("BrojVerzije", "Broj verzije"), ("DatumPostavljanja", "Datum"), ("OpisIzmene", "Opis izmene"), ("OdgovornaOsoba", "Odgovorna osoba")]),
    ("DodajKljucnuRecForm", "Dodaj kljucnu rec", "idPublikacije", [("KljucnaRec", "Kljucna rec")]),
    ("IzmeniKljucnuRecForm", "Izmeni kljucnu rec", "idPublikacije", [("KljucnaRec", "Kljucna rec")]),
    ("DodajCitatForm", "Dodaj citat", "idPublikacije", [("Citat", "Publikacija citat"), ("TipCitata", "Tip citata"), ("MestoCitiranja", "Mesto citiranja")]),
    ("IzmeniCitatForm", "Izmeni citat", "idPublikacije", [("TipCitata", "Tip citata"), ("MestoCitiranja", "Mesto citiranja"), ("Kontekst", "Tekstualni kontekst")]),
    ("DodajPovezanuPublikacijuForm", "Dodaj povezanu publikaciju", "idPublikacije", [("Publikacija", "Publikacija"), ("TipPovezanosti", "Tip povezanosti")]),
    ("IzmeniPovezanuPublikacijuForm", "Izmeni povezanu publikaciju", "idPublikacije", [("TipPovezanosti", "Tip povezanosti")]),
    ("DodajTelefonIstrazivacaForm", "Dodaj telefon", "idIstrazivaca", [("Telefon", "Telefon")]),
    ("IzmeniTelefonIstrazivacaForm", "Izmeni telefon", "idIstrazivaca", [("Telefon", "Telefon")]),
    ("DodajEmailIstrazivacaForm", "Dodaj email", "idIstrazivaca", [("Email", "Email")]),
    ("IzmeniEmailIstrazivacaForm", "Izmeni email", "idIstrazivaca", [("Email", "Email")]),
    ("DodajAngazovanjeForm", "Dodaj angazovanje", "idIstrazivaca", [("Institucija", "Institucija"), ("OrganizacionaJedinica", "Org. jedinica"), ("TipAngazovanja", "Tip"), ("NazivPozicije", "Pozicija"), ("DatumPocetka", "Datum pocetka"), ("DatumZavrsetka", "Datum zavrsetka")]),
    ("IzmeniAngazovanjeForm", "Izmeni angazovanje", "idIstrazivaca", [("OrganizacionaJedinica", "Org. jedinica"), ("TipAngazovanja", "Tip"), ("NazivPozicije", "Pozicija"), ("DatumPocetka", "Datum pocetka"), ("DatumZavrsetka", "Datum zavrsetka")]),
    ("DodajAutorstvoForm", "Dodaj publikaciju autoru", "idAutora", [("Publikacija", "Publikacija"), ("Redosled", "Redosled"), ("TipDoprinosa", "Tip doprinosa"), ("Uloga", "Uloga")]),
    ("IzmeniAutorstvoForm", "Izmeni autorstvo", "idAutora", [("Redosled", "Redosled"), ("TipDoprinosa", "Tip doprinosa"), ("Uloga", "Uloga")]),
    ("DodajKontaktTelefonForm", "Dodaj kontakt telefon", "idInstitucije", [("KontaktTel", "Telefon")]),
    ("IzmeniKontaktTelefonForm", "Izmeni kontakt telefon", "idInstitucije", [("KontaktTel", "Telefon")]),
    ("DodajKontaktMailForm", "Dodaj kontakt mail", "idInstitucije", [("KontaktMail", "Email")]),
    ("IzmeniKontaktMailForm", "Izmeni kontakt mail", "idInstitucije", [("KontaktMail", "Email")]),
    ("DodajNaucnuOblastForm", "Dodaj naucnu oblast", "idInstitucije", [("NaucnaOblast", "Naucna oblast")]),
    ("IzmeniNaucnuOblastForm", "Izmeni naucnu oblast", "idInstitucije", [("NaucnaOblast", "Naucna oblast")]),
    ("DodajAngazovanjeInstitucijeForm", "Dodaj zaposlenog", "idInstitucije", [("Istrazivac", "Istrazivac"), ("TipAngazovanja", "Tip"), ("NazivPozicije", "Pozicija"), ("DatumPocetka", "Datum pocetka")]),
    ("IzmeniAngazovanjeInstitucijeForm", "Izmeni angazovanje", "idInstitucije", [("TipAngazovanja", "Tip"), ("NazivPozicije", "Pozicija"), ("DatumPocetka", "Datum pocetka"), ("DatumZavrsetka", "Datum zavrsetka")]),
    ("DodajPodrzanuPlatformuForm", "Dodaj platformu", "idPublikacije", [("PodrzanaPlatforma", "Platforma")]),
    ("IzmeniPodrzanuPlatformuForm", "Izmeni platformu", "idPublikacije", [("PodrzanaPlatforma", "Platforma")]),
    ("DodajUrednikaKnjigeForm", "Dodaj urednika knjige", "idPublikacije", [("Urednik", "Urednik")]),
    ("IzmeniUrednikaKnjigeForm", "Izmeni urednika knjige", "idPublikacije", [("Urednik", "Urednik")]),
    ("DodajUrednikaPoglavljaForm", "Dodaj urednika poglavlja", "idPublikacije", [("Urednik", "Urednik")]),
    ("IzmeniUrednikaPoglavljaForm", "Izmeni urednika poglavlja", "idPublikacije", [("Urednik", "Urednik")]),
]
for n, t, p, f in relation_inputs:
    gen_input(n, t, f, parent_param=p)

print(f"Generisano formi u: {FORME}")
print(f"Ukupno .cs fajlova: {len(list(FORME.glob('*.cs')))}")
