using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Patholab_DAL_V1;
using System.IO;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Patholab_XmlService;
using LSSERVICEPROVIDERLib;
using System.Text.RegularExpressions;
using NewResultEntry.Controls.Extra_req_Entities;

namespace NewResultEntry.Controls
{
    public partial class FrmColor : Telerik.WinControls.UI.RadForm
    {
        #region Fields



        private List<string> listPart_I, listPart_H, listPart_O;

        private DataLayer _dal;


        const string ADD_SLIDE= "Add Slide";
        // private long sid;
        public List<int> QuantityColList { get; set; }
     //   private  Dictionary<string,string> exrqstatusList;
     //   private  List<ExWrapper> extr4sdg;
        private const int        TreeItemHeight = 19;
        private List<ColNum> _table1_I, _table1_H,_table1_O 
            ,_table2_O, _table2_I, _table2_H,
            _table3_O,_table3_I,_table3_H,
        _table4_O,_table4_I,_table4_H;
   //     public event Action<List<ColNum>> ColorsSelected;
        public List<ColNum> SelectedColors { get; private set; }
        public bool approved { get; private set; }

        private   SDG _sdg;
        private   BlockWrapper selectedBlock;
        private List<RadGridView> gridViews;
        #endregion

        private List<List<ColNum>> tables;
        public FrmColor ( DataLayer dal, SDG sdg )
        {
            this.Load += FrmColor_Load;

 

            QuantityColList = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            this._dal = dal;
            this._sdg = sdg;
            this.WindowState = FormWindowState.Maximized;

            SelectedColors = new List<ColNum> ( );

            tables = new List<List<ColNum>> { 
                (_table1_I = new List<ColNum> ( ))
              ,(  _table2_I = new List<ColNum> ( ))
              ,(  _table3_I = new List<ColNum> ( ))
              ,(  _table1_H = new List<ColNum> ( ))
              ,(  _table2_H = new List<ColNum> ( ))
              ,(  _table3_H = new List<ColNum> ( ))
              ,(  _table1_O = new List<ColNum> ( ))
              ,(  _table2_O = new List<ColNum> ( ))
              ,(  _table3_O = new List<ColNum> ( ))
              ,(  _table4_O = new List<ColNum> ( ))
              ,(  _table4_I = new List<ColNum> ( ))
              ,(  _table4_H = new List<ColNum> ( ))
              
            };




            //   dal.ReloadEntity ( this._sdg );

            InitializeComponent ( );

            listPart_I = this._dal.FindBy<U_PARTS_USER>
                ( x => x.U_PART_TYPE == "I" ).OrderBy ( d => d.U_ORDER ).Select ( x => x.U_STAIN ).ToList ( );

            listPart_H = this._dal.FindBy<U_PARTS_USER>
                ( x => x.U_PART_TYPE == "H" ).OrderBy ( d => d.U_ORDER ).Select ( x => x.U_STAIN ).ToList ( );

            listPart_O = this._dal.FindBy<U_PARTS_USER>
                    ( x => x.U_PART_TYPE == "O" ).OrderBy ( d => d.U_ORDER ).Select ( x => x.U_STAIN ).ToList ( );


            gridViews = new List<RadGridView> ( )
            {
                gridColors, gridColors2, gridColors3,gridColors4
            };

            gridViews.ForEach ( BuildGrid );


            BuildData ( listPart_I, _table1_I, _table2_I, _table3_I, _table4_I );
            BuildData ( listPart_H, _table1_H, _table2_H, _table3_H, _table4_H );
            BuildData ( listPart_O, _table1_O, _table2_O, _table3_O, _table4_O );
      

        }

        private void FrmColor_Load ( object sender, EventArgs e )
        {


            lbox_ColorType.SelectedIndex = 0;
        }





        private void BuildGrid ( RadGridView grid )
        {

            grid.AutoGenerateColumns = false;

            GridViewTextBoxColumn gvtc = new GridViewTextBoxColumn ( "Color" );
            gvtc.FieldName = "Color";
            gvtc.Width = 150;
            gvtc.ReadOnly = true;
            grid.Columns.Add ( gvtc );

            GridViewComboBoxColumn comboColumn = new GridViewComboBoxColumn ( "Quantity" );
            comboColumn.Width = 80;
            comboColumn.FieldName = "Quantity";

            comboColumn.DataSource = QuantityColList;
            grid.Columns.Add ( comboColumn );

            //   dataSource = new List<ColNum>();
            grid.RowFormatting += gridColors_RowFormatting;
            grid.CellClick += ( this.gridColors_CellClick );
        }
        private void BuildData ( List<string> fullList, List<ColNum> t1, List<ColNum> t2, List<ColNum> t3, List<ColNum> t4 )
        {
            int tablesN = gridViews.Count;
            var div=     fullList.Count / tablesN;
            for ( var i = 0; i < div; i++ )
                t1.Add ( new ColNum { Color = fullList [ i ], Quantity = 0 } );
            for ( var i = div; i < div * 2; i++ )
                t2.Add ( new ColNum { Color = fullList [ i ], Quantity = 0 } );
            for ( var i = div * 2; i < div*3; i++ )
                t3.Add ( new ColNum { Color = fullList [ i ], Quantity = 0 } );
            for ( var i = div * 3; i < fullList.Count; i++ )
                t4.Add ( new ColNum { Color = fullList [ i ], Quantity = 0 } );


        }



        private void lbox_ColorType_SelectedIndexChanged ( object sender, EventArgs e )
        {
            if ( lbox_ColorType.SelectedIndex == 0 )
            {
                this.gridColors.DataSource = _table1_I;
                this.gridColors2.DataSource = _table2_I;
                this.gridColors3.DataSource = _table3_I;
                this.gridColors4.DataSource = _table4_I;
            }

            if ( lbox_ColorType.SelectedIndex == 1 )
            {
                this.gridColors.DataSource = _table1_H;
                this.gridColors2.DataSource = _table2_H;
                this.gridColors3.DataSource = _table3_H;
                this.gridColors4.DataSource = _table4_H;

            }
            if ( lbox_ColorType.SelectedIndex == 2 )
            {
                this.gridColors.DataSource = _table1_O;
                this.gridColors2.DataSource = _table2_O;
                this.gridColors3.DataSource = _table3_O;
                this.gridColors4.DataSource = _table4_O;

            }

        }

        private void btn_addColors_Click ( object sender, EventArgs e )
        {
            SelectedColors.Clear ( );
            List<ColNum> list=new List<ColNum> ( );

            foreach ( List<ColNum> colNums in tables )
            {
                list.AddRange ( colNums.Where ( x => x.Quantity > 0 ).ToList ( ) );
            }



            //       list.AddRange ( tables.Where (tbl=>tblForEach() );
            //        list.AddRange ( list2 );
            SelectedColors = list;


            approved = true;
            this.Close ( );
        }

        private void gridColors_RowFormatting ( object sender, Telerik.WinControls.UI.RowFormattingEventArgs e )
        {

            if ( ( ColNum ) e.RowElement.Data.DataBoundItem != null && ( ( ColNum ) e.RowElement.Data.DataBoundItem ).Quantity > 0 )
            {
                e.RowElement.DrawFill = true;
                e.RowElement.GradientStyle = GradientStyles.Solid;
                e.RowElement.BackColor = Color.Aqua;
            }
            else
            {
                e.RowElement.ResetValue ( LightVisualElement.BackColorProperty, ValueResetFlags.Local );
                e.RowElement.ResetValue ( LightVisualElement.GradientStyleProperty, ValueResetFlags.Local );
                e.RowElement.ResetValue ( LightVisualElement.DrawFillProperty, ValueResetFlags.Local );
            }
        }

        private void gridColors_CellClick ( object sender, GridViewCellEventArgs e )
        {

            var col =e.Row.DataBoundItem as ColNum;// grid.Rows [ e.RowIndex ].Cells [ 1 ];
            if ( col != null )
            {


                int val =  col.Quantity;
                if ( val == 0 )
                {
                    e.Row.Cells [ 1 ].Value = val + 1;
                }
                else
                {
                    e.Row.Cells [ 1 ].Value = 0;
                }
            }
        }




        internal void LoadBlockData ( Dictionary<string, int> colorsDictionary )
        {
            approved = false;


            //Init prev List
            SelectedColors.Clear ( );

            //Init grids
            gridViews.ForEach ( x => x.DataSource = null );


            tables.ForEach ( tbl => tbl.ForEach ( x => x.Quantity = 0 ) );


            if ( colorsDictionary != null )
            {
                //    return;


                foreach ( var item in colorsDictionary )
                {

                    // var tg=    tables.Contains(x => x.Where(xn => xn.Color == item.Key));
                    foreach ( List<ColNum> colNums in tables )
                    {
                        var record = colNums.FirstOrDefault ( x => x.Color == item.Key );
                        if ( record != null )
                        {
                            record.Quantity = item.Value;

                        }



                    }

                }
            }

            lbox_ColorType.SelectedIndex = -1;
            lbox_ColorType.SelectedIndex = 0;
        }

        private void button1_Click ( object sender, EventArgs e )
        {
            approved = false;

            this.Close ( );
        }

    }
}