
import java.sql.*;
import java.io.*;
import java.util.*;

public class SQLiteBD
{
    private static String _STR_CONEXAO_ = "jdbc:sqlite:Alunos.db";
    public static void main(String []s)
    {
        SQLiteBD bd = new SQLiteBD();
	try{
           
           /*Aluno a = new Aluno();
           a.setNome("Maria");
           a.setMatricula(2);
           a.setNota1(8);
           a.setNota2(10);
	   bd.Inserir(a);*/

           /*for(Aluno a : bd.obterAlunos())
              System.out.println( ""+a.getMatricula() + "\t" + a.getNome()+"\t"+ a.getNota1()+"\t"+a.getNota2());
              */

        }catch(Exception e)
        {
             e.printStackTrace();
             System.exit(0);
        }
    }

    public SQLiteBD()
    {
	try{
           //1. carregar para a memoria a classe do driver JDBC org.sqlite.JDBC
           Class.forName("org.sqlite.JDBC");// passo 1 - carregar o driver do banco

           File f = new File("Alunos.db");
           if (!f.exists())
              criarBanco();
        }catch(Exception e)
        {
             e.printStackTrace();
             System.exit(0);
        }
    }

    public void inserir(Aluno a)
    {
        try{
           //2. conectar com o banco de dados
           Connection conn = DriverManager.getConnection(_STR_CONEXAO_);
	   //3 - criar ambiente de execução de consulta sql
	   PreparedStatement stmt = conn.prepareStatement("insert into Aluno(Matricula,Nome,Nota1,Nota2,Foto) values (?,?,?,?,?)");
           //4 - criar e executar a consulta sql
	   stmt.setInt(1,a.getMatricula());
	   stmt.setString(2,a.getNome());
	   stmt.setFloat(3,a.getNota1());
	   stmt.setFloat(4,a.getNota2());
	   stmt.setBytes(5,null);
	   //stmt.setBytes(5,ImageToBytes(a.getFoto()));
   	   stmt.executeUpdate();
		//4.1 - pegar os dados do resultset
                //4.2 - manipular o resultset
                //4.3 - fechar result set
           //5 - fechar o ambiente de execução
           stmt.close();
 	   //6 - fechar conexao com banco
           conn.close();
	}
        catch(Exception e)
        {
           e.printStackTrace();
           System.exit(0);
        }
    }

    public void alterar(int Matricula, Aluno a)
    {
        try{
           //2. conectar com o banco de dados
           Connection conn = DriverManager.getConnection(_STR_CONEXAO_);
	   //3 - criar ambiente de execução de consulta sql
	   PreparedStatement stmt = conn.prepareStatement("update Aluno set Matricula=?, Nome=?,Nota1=?,Nota2=? where Matricula=?");
           //4 - criar e executar a consulta sql
	   stmt.setInt(1,a.getMatricula());
	   stmt.setString(2,a.getNome());
	   stmt.setFloat(3,a.getNota1());
	   stmt.setFloat(4,a.getNota2());
           stmt.setInt(5,Matricula);
	   //stmt.setBytes(5,ImageToBytes(a.getFoto()));
   	   stmt.executeUpdate();
           //5 - fechar o ambiente de execução
           stmt.close();
 	   //6 - fechar conexao com banco
           conn.close();
	}
        catch(Exception e)
        {
           e.printStackTrace();
           System.exit(0);
        }
    }

    public void remover(int Matricula)
    {
        try{
           //2. conectar com o banco de dados
           Connection conn = DriverManager.getConnection(_STR_CONEXAO_);
	   //3 - criar ambiente de execução de consulta sql
	   PreparedStatement stmt = conn.prepareStatement("delete from Aluno where Matricula=?");
           //4 - criar e executar a consulta sql
	   stmt.setInt(1,Matricula);
   	   stmt.executeUpdate();
           //5 - fechar o ambiente de execução
           stmt.close();
 	   //6 - fechar conexao com banco
           conn.close();
	}
        catch(Exception e)
        {
           e.printStackTrace();
           System.exit(0);
        }
    }

    public void removerTudo()
    {
        try{
           //2. conectar com o banco de dados
           Connection conn = DriverManager.getConnection(_STR_CONEXAO_);
	   //3 - criar ambiente de execução de consulta sql
	   PreparedStatement stmt = conn.prepareStatement("delete from Aluno");
           //4 - criar e executar a consulta sql
   	   stmt.executeUpdate();
           //5 - fechar o ambiente de execução
           stmt.close();
 	   //6 - fechar conexao com banco
           conn.close();
	}
        catch(Exception e)
        {
           e.printStackTrace();
           System.exit(0);
        }
    }

   public Aluno obterAluno(int Matricula)
   {
     Aluno a=null;
     try{
	Connection conn = DriverManager.getConnection(_STR_CONEXAO_);
	if (conn != null) {
		PreparedStatement stmt = conn.prepareStatement("select Matricula,nome,nota1, nota2, foto from aluno where Matricula=?");
		stmt.setInt(1,Matricula);
		ResultSet r = stmt.executeQuery();
		if (r.next())
		{
		   a = new Aluno();
                   a.setMatricula(r.getInt(1));
		   a.setNome(r.getString(2));
		   a.setNota1(r.getFloat(3));
		   a.setNota2(r.getFloat(4));
                   //a.setFoto(BytesToImage(r.getBytes(5)));
		}
                stmt.close();
		conn.close();
        }
	return a;
     }catch(Exception e)
     {
         e.printStackTrace();
         System.exit(0);
	 return null;
     }
   }

    public Collection<Aluno> obterAlunos()
    {
        LinkedList<Aluno> L = new LinkedList<Aluno>();
        try{
           //2. conectar com o banco de dados
           Connection conn = DriverManager.getConnection(_STR_CONEXAO_);
	   //3 - criar ambiente de execução de consulta sql
	   PreparedStatement stmt = conn.prepareStatement("select Matricula, Nome, Nota1, Nota2 from Aluno order by Nome");
           //4 - criar e executar a consulta sql
   	   ResultSet r = stmt.executeQuery();
		//4.1 - pegar os dados do resultset
                //4.2 - manipular o resultset
           while (r.next())
           {
               Aluno a = new Aluno();
               a.setMatricula( r.getInt(1) );
               a.setNome( r.getString(2) );
               a.setNota1( r.getFloat(3) );
               a.setNota2( r.getFloat(4) );
	       L.add(a);
           }
               //4.3 - fechar result set
           r.close();
           //5 - fechar o ambiente de execução
           stmt.close();
 	   //6 - fechar conexao com banco
           conn.close();
	   return L;
	}
        catch(Exception e)
        {
           e.printStackTrace();
           System.exit(0);
           return L;
        }
    }


    public void criarBanco()
    {
      try{
           //2. conectar com o banco de dados
           Connection conn = DriverManager.getConnection(_STR_CONEXAO_);
	   //3 - criar ambiente de execução de consulta sql
	   Statement stmt = conn.createStatement();
           //4 - criar e executar a consulta sql
   	   stmt.executeUpdate("create table Aluno( "+
                          "Matricula int not null primary key, "+
                          "Nome varchar(30) not null,"+
                          "Nota1 float, Nota2 float,"+
                          "Foto blob)");
		//4.1 - pegar os dados do resultset
                //4.2 - manipular o resultset
                //4.3 - fechar result set
           //5 - fechar o ambiente de execução
           stmt.close();
 	   //6 - fechar conexao com banco
           conn.close();
      }catch(Exception e)
      {
         e.printStackTrace();
         System.exit(0);
      }
   }
   /*
   private static byte[] ImageToBytes(java.awt.Image img)
   {
      try{
	if (img==null)
           return null;
  	java.io.ByteArrayOutputStream memoria = new java.io.ByteArrayOutputStream();
        javax.imageio.ImageIO.write((java.awt.image.BufferedImage)img, "PNG", memoria);
	byte []v = memoria.toByteArray();
	return v;
     }catch(Exception e)
     {
       return null;
     }
   }
   private static java.awt.Image BytesToImage(byte []b)
   {
      try{
        if (b==null)
          return null;
  	java.io.ByteArrayInputStream memoria = new java.io.ByteArrayInputStream(b);
        java.awt.Image img = javax.imageio.ImageIO.read(memoria);
	return img;
      }
      catch(Exception e)
      {
        return null;
      }
   }
*/
}
