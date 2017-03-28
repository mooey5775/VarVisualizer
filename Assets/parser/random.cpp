#include <iostream>
#include <vector>

using namespace std;

int main(){
    int fibnums=10;

    vector<int> f(fibnums);
    f[0]=1; f[1]=1;
    for (int i=2;i<fibnums;i++){
        f[i]=f[i-2]+f[i-1];
    }

    return 0;
}
