#include <iostream>
#include <fstream>
#include <vector>
#include <fstream>
#include <algorithm>
#include <cmath>
#include <string>
#include <map>

using namespace std;

int stoi(string a){

    int ans=0;
    for (int i=0;i<a.size();i++){
        ans*=10;
        ans+=a[i]-'0';
    }
    cout << "converted |"<<a << "| to "<<ans<<endl;
    return ans;
}

string cut(string a){
    for (int i=0;i<a.size();i++)
        if (a[i]!=' ' && a[i]!='\t') return a.substr(i);
    return "";
}
string li="List<int>";
string fo="for (";
string it="int ";

int main(){
    ifstream input("GlobalMembers.cs");
    ofstream output("GlobalMembers_out.cs");

    map<string, int> values;
    map<string, vector<int> > lists;

    bool started=false;

    while (true){
        string in;
        getline(input,in);

        if (!started && in=="static int Main()"){
            started=true;
            continue;
        }

        if (started && in!="{" && cut(in)!="return 0;"){
        output <<in<< endl;

            in=cut(in);
            if (in.substr(0,li.size())==li){
                //list instantiated
                if (in.find("=")!=std::string::npos){
                    //has =
                    int start=in.find(" ")+1;
                    int endd=in.find(" ",start+1);
                    string name=in.substr(start,endd-start);

                    int start2=in.find("(")+1;
                    int endd2=in.find(")",start2+1);
                    string size2=in.substr(start2,endd2-start2);

                    if (values.find(size2)==values.end() || values[size2]==69420){
//                        output << "instantiate list named |" << name << "| of size "<< size2 <<endl
                    output << "q.Enqueue(new Event("<<name<<","<< stoi(size2)<<",0,0,3))"<<endl;
                    }
                    else
//                        output << "instantiate list named |" << name << "| of size "<< values[size2] <<endl;
                    output << "q.Enqueue(new Event("<<name<<","<< values[size2]<<",0,0,3))"<<endl;
                }else{
                    int start=in.find(" ")+1;
                    int endd=in.find(";",start+1);
                    string name=in.substr(start,endd-start);
//                    output << "instantiate list named |" << name << "| of unknown size" <<endl;
                    output << "q.Enqueue(new Event("<<name<<",0,0,0,2))"<<endl;

                }
            }else if (in.substr(0,it.size())==it){
                //int instantiated
                if (in.find("=")!=std::string::npos){
                    //found =
                    int start=in.find(" ")+1;
                    int endd=in.find(" ",start+1);
                    string name=in.substr(start,endd-start);

                    int start2=in.find(" ",in.find(" ",endd)+1)+1;
                    int endd2=in.find(";",start2);
                    string val=in.substr(start2,endd2-start2);

//                    output << "instantiate int named |" << name << "| of value " << val<<endl;
                    output << "q.Enqueue(new Event("<<name<<","<<stoi(val)<<",0,0,1))"<<endl;
                    values[name]=stoi(val);
                }else{
                    int start=in.find(" ")+1;
                    int endd=in.find(";",start+1);
                    string name=in.substr(start,endd-start);

//                    output << "instantiate int named |" << name << "| of unknown value"<<endl;
                    output << "q.Enqueue(new Event("<<name<<",0,0,0,0))"<<endl;
                    values[name]=69420;
                }

            }else if (in.substr(0,fo.size())==fo){
                //for loop instantiated
                int start=in.find(" ",fo.size())+1;
                int endd=in.find(" ",start+1);
                string name=in.substr(start,endd-start);

                int start2=in.find(" ",endd+1)+1;
                int endd2=in.find(";",start2+1);
                string val=in.substr(start2,endd2-start2);

//                output << "instantiate int named |" << name << "| of value|"<<val<<"|(-1)"<<endl;
                output << "q.Enqueue(new Event("<<name<<","<<stoi(val)-1<<",0,0,1))"<<endl;


//                output << "add 1 to int named |" << name <<endl;
                output << "q.Enqueue(new Event("<<name<<","<<values[name]+1<<",0,0,6))"<<endl;


//                values[name]=stoi(val)-1;

            }else if (in.find("=")!=string::npos){
                string before=in.substr(0,in.find("="));
                string after=in.substr(in.find("=")+1);
                after=cut(after);

                if (before.find("[")!=string::npos){
                    int start=0;
                    int endd=before.find("[");
                    string name=in.substr(start,endd-start);

                    int istart=before.find("[")+1;
                    int iend=before.find("]");
                    string index=before.substr(istart,iend-istart);

                    if (after.find("[")!=string::npos){
                        if (in=="f[i] += f[i - 2];"){
                            output << "change var f index i to f index i-2" << endl;
                            lists["f"][i]+=lists["f"][i-2];
                        }else if (in=="f[i] += f[i - 1];"){
                            output << "change var f index i to f index i-1" << endl;
                            lists["f"][i]+=lists["f"][i-1];
                        }
                    }else{
                        int start2=in.find(" ",in.find(" ")+1)+1;
                        int endd2=in.find(";");
                        string val=in.substr(start2,endd2-start2);


                        output << "change var |"<<name<<"| index |"<<index<<"| to |"<<val<<endl;
                    }

            }



        }





    }

        if (cut(in)=="return 0;")return 0;
        }

return 0;
    }
