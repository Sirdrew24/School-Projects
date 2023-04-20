import javafx.application.Application;
import javafx.scene.Scene;
import javafx.scene.Group;
import javafx.stage.Stage;
import javafx.scene.shape.Line;
import javafx.scene.shape.Ellipse;
import javafx.scene.shape.Circle;
import javafx.scene.paint.Color;

public class ArtClass extends Application
{
    public void start(Stage primaryStage){
        Line line1 = new Line(12, 65, 134, 345);
            line1.setStroke(Color.GRAY);
            line1.setStrokeWidth(5);
        Line line2 = new Line(65, 81, 952, 324);
            line2.setStroke(Color.RED);
            line2.setStrokeWidth(3);
        Line line3 = new Line(709, 432, 865, 534);
            line2.setStrokeWidth(4);
        Ellipse ellipse1 = new Ellipse(250, 150, 170, 100);
            ellipse1.setStroke(Color.YELLOW);
            ellipse1.setFill(Color.YELLOW);
        Ellipse ellipse2 = new Ellipse(945, 481, 34, 84);
            ellipse2.setStroke(Color.BLUE);
            ellipse2.setStrokeWidth(5);
            ellipse2.setFill(null);
        Circle circle1 = new Circle(500, 125, 20);
            circle1.setFill(Color.PINK);
        Circle circle2 = new Circle(620, 363, 50);
            circle2.setFill(null);
            circle2.setStroke(Color.WHITE);
            circle2.setStrokeWidth(8);
        
        Group root = new Group(line1, line2, line3, ellipse1, ellipse2, circle1, circle2);    
        Scene scene = new Scene(root, 960, 540, Color.GREEN);
        primaryStage.setTitle("My Art Piece");
        primaryStage.setScene(scene);
        primaryStage.show();
    }
}
