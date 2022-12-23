using System;
namespace koo
{
  class complex
{
  int r,i;

public complex()
{
r=0;
i=0;
}
public complex(int r,int i)
{
this.r=r;
this.i=i;
}
public static complex operator +(complex c1,complex c2)      //add of two obj
{
   complex temp=new complex();
temp.r=c1.r+c2.r;
temp.i=c1.i+c2.i;
return temp;

}
public static complex operator +(complex c1,int a)    //add of obj and int
{  complex temp=new complex();
temp.r=c1.r+a;
temp.i=c1.i+a;
return temp;
}
public static complex operator -(complex c1,complex c2)  //sub of 2 obj
{
 complex temp=new complex();
temp.r=c1.r-c2.r;
temp.i=c1.i-c2.i;
return temp;
}
public static complex operator -(complex c1,int a)   //substraction of objext and int
{complex temp=new complex();
temp.r=c1.r-a;
temp.i=c1.i-a;
return temp;
}
public static complex operator *(complex c1,complex c2)   //multiplication od 2 object
{
  complex temp=new complex();
   temp.r=c1.r*c2.r;
   temp.i=c2.i*c2.i;
  return temp;
}
public static complex operator *(complex c1,int a)     // multiplication
{
complex temp=new complex();
temp.r=c1.r*a;
temp.i=c1.i*a;
return temp;

}
public static complex operator / (complex c1 ,complex c2)    //division of 2 obj
{complex temp=new complex();
temp.r=c1.r/c2.r;
temp.i=c1.i/c2.i;
return temp;

}
public static complex operator / (complex c1 ,int a)
{complex temp=new complex();
temp.r=c1.r/a;
temp.i=c1.i/a;
return temp;
}
public void display()
{
Console.WriteLine($"{r}+{i}i");
    }
}
class a
{
  static void Main()
{
   complex c1=new complex(12,43);
   complex c2=new complex(65,65);
 complex c3=new complex();
c3=c1+c2;
c3.display();
complex c4=new complex();
c4=c1+5;
c4.display();
complex c5=new complex();
c5=c1-c2;
c5.display();
complex c6=new complex();
c6=c1-6;
c6.display();
complex c7=new complex();
c7=c1*c2;
c7.display();
complex c8=new complex();
c8=c1*8;
c8.display();
complex c9 =new complex();
c9=c1/c2;
c9.display();
complex c10 =new complex();
c10=c1/6;
c10.display();
}

}


}