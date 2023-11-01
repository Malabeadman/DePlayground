import java.util.Arrays;

class HelloWorld {
    public static void main(String[] args) {
        System.out.println("Hello, World!");
        reverseWords("Hannah");
    }
    
     static void reverseWords(String word){
        
        char[] wordArray = word.toCharArray();
        char[] backwards = new char[word.length()];
       int wordLength = word.length();
       System.out.println("word: " + word);
       System.out.println("word length: " + wordLength);
       
       for(int i = 0; i < wordLength; i++){
           
            System.out.println("WordArray br/: " + wordArray[i]);
            int size = wordLength - 1;
            backwards[i] = wordArray[size - i];
       }
       System.out.println("wordArray: " + wordArray);
       System.out.println("wordArray: " + backwards);
       System.out.println("Arrays is: " + Arrays.equals(wordArray, backwards));
       if (Arrays.equals(wordArray, backwards)){
            System.out.println("yesss");
       }
       else{
                       System.out.println("Nooooope");
       }
       //System.out.println("flipped " + backwards);

    }
}