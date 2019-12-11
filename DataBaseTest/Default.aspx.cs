using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataBaseTest
{
    public partial class Default : System.Web.UI.Page
    {
        // 接続文字列をコンストラクタの引数にしてSqlConnectionクラスのオブジェクト con を作成する。
        
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\NSW00_008806\\Desktop\\DataBaseTest\\DataBaseTest\\App_Data\\SyainDB.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            // Openメソッドでデータベースに接続する。
            con.Open();

            // 「ThermalTable」という名前のテーブルからすべての列を取得するためのSQLコマンドをstrSqlに代入する。
            //string strSql = "SELECT * FROM ThermalTable";
            string strSql = "SELECT * FROM test";
            // SqlCommandクラスのオブジェクトcmdを作成する。
            // 第一引数はSQLコマンド、第二引数はデータベースの接続情報。
            SqlCommand cmd = new SqlCommand(strSql, con);

            // ExecuteReaderメソッドは、SQLを実行し、戻り値にSqlDataReaderオブジェクトを返す。
            // SqlDataReaderは、SQLの結果を操作するクラスである。
            SqlDataReader dr = cmd.ExecuteReader();

            // 読み込んだデータをテーブルに追加する。(読み込む行がなくなるまで繰り返し処理を行う)
            // Readメソッドは取得した結果を1行読み込む。読み込む行がない場合はFalseを返す。
            while (dr.Read())
            {
                // Readメソッドで読み込んだ1行分のデータをテーブルコントロールに追加するには次のようにする。

                // TableRowクラスのオブジェクトtRowを作成。
                TableRow tRow = new TableRow();

                // TableCellクラスのオブジェクトtCell(セル)を4つ作成。
                TableCell tCell1 = new TableCell();
                TableCell tCell2 = new TableCell();
                TableCell tCell3 = new TableCell();
                TableCell tCell4 = new TableCell();
                TableCell tCell5 = new TableCell();
                TableCell tCell6 = new TableCell();
                TableCell tCell7 = new TableCell();
                TableCell tCell8 = new TableCell();
                TableCell tCell9 = new TableCell();
                TableCell tCell10 = new TableCell();
                TableCell tCell11 = new TableCell();
                TableCell tCell12 = new TableCell();
                TableCell tCell13 = new TableCell();
                /*
                // tCellのTextプロパティにデータベースから取得したデータを代入する。
                // 別のデータを取得するには、dr("別名")とする。
                // tRowにセルをそれぞれ追加する。
                tCell1.Text = dr["建物名"].ToString();   // dr("Sya_ID")は数値なので、文字列に変換する。
                tRow.Cells.Add(tCell1);

                tCell2.Text = dr["観測日"].ToString();
                tRow.Cells.Add(tCell2);

                tCell3.Text = dr["壁面"].ToString();
                tRow.Cells.Add(tCell3);

                tCell4.Text = dr["画像名"].ToString();
                tRow.Cells.Add(tCell4);

                tCell5.Text = dr["ID"].ToString();
                tRow.Cells.Add(tCell5);

                tCell6.Text = dr["面積"].ToString();
                tRow.Cells.Add(tCell6);

                tCell7.Text = dr["評価"].ToString();
                tRow.Cells.Add(tCell7);

                tCell8.Text = dr["ΔT"].ToString();
                tRow.Cells.Add(tCell8);

                tCell9.Text = dr["x"].ToString();
                tRow.Cells.Add(tCell9);

                tCell10.Text = dr["y"].ToString();
                tRow.Cells.Add(tCell10);

                tCell11.Text = dr["幅"].ToString();
                tRow.Cells.Add(tCell11);

                tCell12.Text = dr["高さ"].ToString();
                tRow.Cells.Add(tCell12);

                tCell13.Text = dr["Check"].ToString();
                tRow.Cells.Add(tCell13);
                */

                tCell1.Text = dr["col1"].ToString();   // dr("Sya_ID")は数値なので、文字列に変換する。
                tRow.Cells.Add(tCell1);

                tCell2.Text = dr["col2"].ToString();
                tRow.Cells.Add(tCell2);

                tCell3.Text = dr["col3"].ToString();
                tRow.Cells.Add(tCell3);

                tCell4.Text = dr["col4"].ToString();
                tRow.Cells.Add(tCell4);

                tCell5.Text = dr["col5"].ToString();
                tRow.Cells.Add(tCell5);

                tCell6.Text = dr["col6"].ToString();
                tRow.Cells.Add(tCell6);

                tCell7.Text = dr["col7"].ToString();
                tRow.Cells.Add(tCell7);

                tCell8.Text = dr["col8"].ToString();
                tRow.Cells.Add(tCell8);

                tCell9.Text = dr["col9"].ToString();
                tRow.Cells.Add(tCell9);

                tCell10.Text = dr["col10"].ToString();
                tRow.Cells.Add(tCell10);

                tCell11.Text = dr["col11"].ToString();
                tRow.Cells.Add(tCell11);

                tCell12.Text = dr["col12"].ToString();
                tRow.Cells.Add(tCell12);

                tCell13.Text = dr["col13"].ToString();
                tRow.Cells.Add(tCell13);
                // テーブルにtRowを追加する。
                tblThermal.Rows.Add(tRow);
            }
            // Closeメソッドで、SqlDataReaderオブジェクトを閉じる。
            dr.Close();

            // Closeメソッドで接続を閉じる。
            con.Close();
        }

        // 登録と変更の共通処理
        private void ExecNonQuery(string strSql)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(strSql, con);

            try
            {
                // ExecuteNonQueryメソッドでSQLコマンドを実行する。
                // 戻り値として、変更のあった行数を返す。
                int numResult = cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                // 例外が発生した場合の処理
            }
            con.Close();

            // Page_Loadを実行して表を更新するために自分自身にリダイレクト
            Response.Redirect("Default.aspx");
        }

        protected void btnInput_Click(object sender, EventArgs e)
        {
            /*
            // データの登録を行うSQLコマンド
            string strSql = "INSERT INTO Syain("
                + "Sya_ID, Sya_Name, Sya_Syozoku, Sya_Mail)VALUES("
                + txtSyaID.Text + ",'"
                + txtSyaName.Text + "','"
                + txtSyaSyozoku.Text + "','"
                + txtSyaMail.Text + "')";
            */

            // 「ThermalTable」テーブルにデータの登録を行うSQLコマンド
            /*
            string strSql = "INSERT INTO test("
                + "col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, col11, col12, col13)VALUES("
                + TextBox1.Text + ",'"
                + TextBox2.Text + "','"
                + TextBox3.Text + "','"
                + TextBox4.Text + "','"
                + TextBox5.Text + "','"
                + TextBox6.Text + "','"
                + TextBox7.Text + "','"
                + TextBox8.Text + "','"
                + TextBox9.Text + "','"
                + TextBox10.Text + "','"
                + TextBox11.Text + "','"
                + TextBox12.Text + "','"
                + TextBox13.Text + "')";
            */
            //string strSql = "INSERT INTO test(col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, col11, col12, col13)VALUES("+TextBox1.Text.ToString()+",'"+TextBox2.Text+"','"+TextBox3.Text.ToString()+ "','" + TextBox4.Text+ "','" + TextBox5.Text+ "','" + TextBox6.Text+ "','" + TextBox7.Text.ToString()+ "','" + TextBox8.Text+ "','" + TextBox9.Text+ "','" + TextBox10.Text+ "','" + TextBox11.Text+ "','" + TextBox12.Text+ "','" + TextBox13.Text+"')";
            //string strSql = "INSERT INTO test(col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, col11, col12, col13)VALUES('1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1')";
            string strSql = "INSERT INTO test(col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, col11, col12, col13)VALUES('学校', '2019/06/07', '南面', 'DJI_1.JPG', '1', '0.1', '経過観察', '3.6', '23', '45', '30', '50', '1')";
            ExecNonQuery(strSql);
        }

        protected void btnChange_Click(object sender, EventArgs e)
        {
            /*
            // データの修正を行うSQLコマンド
            string strSql = "UPDATE Syain SET Sya_Name = '"
                + txtSyaName.Text + "', Sya_Mail = '"
                + txtSyaMail.Text + "', Sya_Syozoku = '"
                + txtSyaSyozoku.Text
                + "' WHERE Sya_ID = "
                + txtSyaID.Text;

            ExecNonQuery(strSql);
            */
        }
    }
}