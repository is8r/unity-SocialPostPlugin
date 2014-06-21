#import "SocialPostClass.h"

extern "C"{
    void twitter_(char *s) {
    	NSString* str = [NSString stringWithCString:s encoding:NSUTF8StringEncoding];
        [SocialPostClass twitter:str];
    }
    void facebook_(char *s) {
    	NSString* str = [NSString stringWithCString:s encoding:NSUTF8StringEncoding];
        [SocialPostClass facebook:str];
    }
}
