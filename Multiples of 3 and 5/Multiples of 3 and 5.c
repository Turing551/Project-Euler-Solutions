#include <stdio.h>

int main(void){
  unsigned long long int sum=0;
  unsigned long int t=0;          
  unsigned long long int n=0;      
  scanf("%lu",&t);
  for(int i=0; i<t; i++){
      scanf("%llu",&n);
      for(int j=3; j<n; j++){
         if(j%3==0 || j%5==0)
         sum = sum+j;
        }
        printf("%llu\n",sum);
        sum=0;
    }
}
