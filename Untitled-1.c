#include <iostream>
    using namespace std;
    int main()
    
    {
        int i,j;
        int tabla [5][3]={'\0'};
        for (i=0; i<5, i++)
        {
            for (j=0; j<3; j++)
            {
                cout<<"CAPTURE UN NUMERO""<<endl;
                cin>>tabla[i][j];
            }
        }
        cout<<"LOS DATOS CAPTURADOS SON:" <<endl;
        for(int i=0; i<5; i++){
            for (j=0; j<3; j++){
                cout<<tabla[i][j]<<" ";}
                cout<<endl;}
                system("pause");
    }