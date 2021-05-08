package mockito;

public class User {
    private String id;
    private String passwordHash;
    private boolean enabled;

    public User(String id, String passwordHash, boolean enabled){
        this.id = id;
        this.passwordHash = passwordHash;
        this.enabled = enabled;
    }

    public boolean isEnabled() {
        return enabled;
    }

    public String getPasswordHash() {
        return passwordHash;
    }
}
