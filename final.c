char x, buff[20];
int i,j,teachmode,a;

void main(){
     UART1_Init(9600);
     TRISB=0;
     TRISD=0;
     PORTB=0;
     PORTD=0;
     teachmode=0;
     while(1){
              if (UART1_Data_Ready()){
                 x=UART1_Read();
              }
              switch (x){
                     case 'A':
                           PORTB.F0 = 1;
                           Delay_ms(1000);
                           PORTB.F0 = 0;
                           if (teachmode=1){
                              buff[i]=x;
                              i++;
                           }
                           break;
                     case 'a':
                           PORTB.F1 = 1;
                           Delay_ms(1000);
                           PORTB.F1 = 0;
                           if (teachmode=1){
                              buff[i]=x;
                              i++;
                           }
                           break;
                     case 'B':
                           PORTD.F6 = 1;
                           Delay_ms(1000);
                           PORTD.F6 = 0;
                           if (teachmode=1){
                              buff[i]=x;
                              i++;
                           }
                           break;
                     case 'b':
                           PORTD.F7 = 1;
                           Delay_ms(1000);
                           PORTD.F7 = 0;
                           if (teachmode=1){
                              buff[i]=x;
                              i++;
                           }
                           break;
                     case 'C':
                           PORTD.F4 = 1;
                           Delay_ms(1000);
                           PORTD.F4 = 0;
                           if (teachmode=1){
                              buff[i]=x;
                              i++;
                           }
                           break;
                     case 'c':
                           PORTD.F5 = 1;
                           Delay_ms(1000);
                           PORTD.F5 = 0;
                           if (teachmode=1){
                              buff[i]=x;
                              i++;
                           }
                           break;
                     case 'D':
                           PORTD.F2 = 1;
                           Delay_ms(1000);
                           PORTD.F2 = 0;
                           if (teachmode=1){
                              buff[i]=x;
                              i++;
                           }
                           break;
                     case 'd':
                           PORTD.F3 = 1;
                           Delay_ms(1000);
                           PORTD.F3 = 0;
                           if (teachmode=1){
                              buff[i]=x;
                              i++;
                           }
                           break;
                     case 'E':
                           PORTD.F0 = 1;
                           Delay_ms(1000);
                           PORTD.F0 = 0;
                           if (teachmode=1){
                              buff[i]=x;
                              i++;
                           }
                           break;
                     case 'e':
                           PORTD.F1 = 1;
                           Delay_ms(1000);
                           PORTD.F1 = 0;
                           if (teachmode=1){
                              buff[i]=x;
                              i++;
                           }
                           break;
                     case 'F':
                           PORTB.F2 = 1;
                           if (teachmode=1){
                              buff[i]=x;
                              i++;
                           }
                           break;
                     case 'f':
                           PORTB.F2 = 0;
                           if (teachmode=1){
                              buff[i]=x;
                              i++;
                           }
                           break;
                     case 'G':
                          if (teachmode=0){
                               teachmode=1;
                               i=0;
                          }
                          else {
                               teachmode=0;
                          }
                          break;
                     case 'g':
                          x='\0';
                          j=0;
                          while (i>0){
                              x=buff[j];
                              switch (x){
                                       case 'A':
                                             PORTB.F0 = 1;
                                             Delay_ms(1000);
                                             PORTB.F0 = 0;
                                             break;
                                       case 'a':
                                             PORTB.F1 = 1;
                                             Delay_ms(1000);
                                             PORTB.F1 = 0;
                                             break;
                                       case 'B':
                                             PORTD.F6 = 1;
                                             Delay_ms(1000);
                                             PORTD.F6 = 0;
                                             break;
                                       case 'b':
                                             PORTD.F7 = 1;
                                             Delay_ms(1000);
                                             PORTD.F7 = 0;
                                             break;
                                       case 'C':
                                             PORTD.F4 = 1;
                                             Delay_ms(1000);
                                             PORTD.F4 = 0;
                                             break;
                                       case 'c':
                                             PORTD.F5 = 1;
                                             Delay_ms(1000);
                                             PORTD.F5 = 0;
                                             break;
                                       case 'D':
                                             PORTD.F2 = 1;
                                             Delay_ms(1000);
                                             PORTD.F2 = 0;
                                             break;
                                       case 'd':
                                             PORTD.F3 = 1;
                                             Delay_ms(1000);
                                             PORTD.F3 = 0;
                                             break;
                                       case 'E':
                                             PORTD.F0 = 1;
                                             Delay_ms(1000);
                                             PORTD.F0 = 0;
                                             break;
                                       case 'e':
                                             PORTD.F1 = 1;
                                             Delay_ms(1000);
                                             PORTD.F1 = 0;
                                             break;
                                       case 'F':
                                             PORTB.F2 = 1;
                                             Delay_ms(1000);
                                             break;
                                       case 'f':
                                             PORTB.F2 = 0;
                                             Delay_ms(1000);
                                             break;
                                             }
                              j++;
                              i--;
                          }
                          break;

              }
              x='\0';
}     }