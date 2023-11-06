package ca.bcit.comp7071.app;

// write a web server for a database app.
import com.sun.net.httpserver.HttpServer;
import com.sun.net.httpserver.HttpHandler;
import com.sun.net.httpserver.HttpExchange;

import java.io.IOException;
import java.io.OutputStream;
import java.net.InetSocketAddress;

public class App {
  public static void main(String[] args) throws IOException {
    int port = 8080; // Port on which the server will listen
    HttpServer server = HttpServer.create(new InetSocketAddress(port), 0);

    // Create a context for a specific path and associate a handler with it
    server.createContext("/health", new HealthCheck());

    // Set the executor for the server (null means default executor)
    server.setExecutor(null);

    // Start the server
    server.start();

    System.out.println("Server is listening on port " + port);
  }

  static class HealthCheck implements HttpHandler {
    @Override
    public void handle(HttpExchange exchange) throws IOException {
      // Get the response output stream
      OutputStream os = exchange.getResponseBody();
      String response = "ok!";
      // Write the response to the output stream
      os.write(response.getBytes());
      os.close();
    }
  }
}
