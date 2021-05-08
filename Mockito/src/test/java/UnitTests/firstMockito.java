package UnitTests;

import mockito.Demo;
import mockito.PasswordEncoder;
import org.junit.Assert;
import org.junit.Test;

import java.util.Collections;

import static org.junit.Assert.*;
import static org.mockito.Mockito.*;

public class firstMockito {
    PasswordEncoder passwordEncoder = mock(PasswordEncoder.class);



    @Test
    public void TestingDemoInterface(){
        Demo demo = mock(Demo.class);
        assertEquals(0, demo.getInt());
        assertEquals(0, demo.getInt());
        assertEquals(0, demo.getInteger().intValue());
        assertEquals(0d, demo.getDouble(), 0d);
        assertFalse(demo.getBoolean());
        assertNull(demo.getObject());
        assertEquals(Collections.emptyList(), demo.getCollection());
        assertNull(demo.getArray());
        assertEquals(0L, demo.getStream().count());
        assertFalse(demo.getOptional().isPresent());
    }

    @Test
    public void usingStubsWhenThenReturn(){
        when(passwordEncoder.encode(anyString())).thenReturn("hola", "adios");
        String actual = passwordEncoder.encode("a");
        String actual2 = passwordEncoder.encode("a");
        Assert.assertEquals("hola", actual);
        Assert.assertEquals("adios",actual2);
    }
    @Test
    public void usingStubsDoReturnWhen(){
        doReturn("hola").when(passwordEncoder).encode("o");

        String actual = passwordEncoder.encode("o");

        Assert.assertEquals("hola",actual);
    }

    @Test
    public void answerMocks(){
        when(passwordEncoder.encode("1")).thenAnswer(
                invocation -> invocation.getArgument(0)+"!");

        String actual = passwordEncoder.encode("1");


    }

    @Test(expected = IllegalArgumentException.class)
    public void throwExceptions(){
        when(passwordEncoder.encode("a")).thenAnswer(
                e ->{ throw new IllegalArgumentException();}
        );
        passwordEncoder.encode("a");
//        passwordEncoder.encode("b");

    }
}
