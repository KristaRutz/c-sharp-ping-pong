using System;

namespace PingPong {
public class Pong {

public Pong() {}

public void DeterminePingOrPong(int value) {

  for(int i = 1; i <= value; i++) {
    
    if((i % 3 == 0) && (i % 5 == 0)) {
      Console.WriteLine("ping-pong");
    } else if((i % 3 == 0)) {
      Console.WriteLine("ping");
    } else if(i % 5 == 0) {
      Console.WriteLine("pong");
    } else {
      Console.WriteLine(i);
    }
}
}
}
}
