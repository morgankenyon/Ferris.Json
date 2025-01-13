## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.StringMemoryBenchmark.TestBaseline()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       mov       rcx,1BD80208708
       mov       edx,22FE
       add       rcx,0C
       mov       r8d,0D921A51F
       mov       r9d,5D0291E6
       call      qword ptr [7FFCD86BFAF8]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       add       eax,esi
       mov       [rbx+8],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M01_L06
       mov       eax,edx
       shr       eax,3
       xchg      ax,ax
M01_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r10d,r8d
       mov       r8d,r9d
       xor       r8d,r10d
       rol       r10d,14
       add       r10d,r8d
       rol       r8d,9
       xor       r8d,r10d
       rol       r10d,1B
       add       r10d,r8d
       rol       r8d,13
       mov       r9d,r8d
       add       rcx,8
       dec       eax
       mov       r8d,r10d
       jne       short M01_L00
       test      dl,4
       je        short M01_L02
M01_L01:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
M01_L02:
       mov       eax,edx
       and       rax,7
       mov       eax,[rcx+rax-4]
       shr       eax,8
       or        eax,80000000
       not       edx
       shl       edx,3
       shrx      edx,eax,edx
M01_L03:
       add       edx,r8d
       mov       eax,r9d
       xor       eax,edx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       mov       ecx,edx
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       ret
M01_L04:
       mov       eax,edx
       and       rax,2
       movzx     eax,byte ptr [rcx+rax]
       or        eax,8000
M01_L05:
       test      dl,2
       mov       edx,eax
       je        short M01_L03
       shl       edx,10
       movzx     eax,word ptr [rcx]
       or        edx,eax
       jmp       short M01_L03
M01_L06:
       cmp       edx,4
       jae       near ptr M01_L01
       mov       eax,80
       test      dl,1
       je        short M01_L05
       jmp       short M01_L04
; Total bytes of code 267
```

## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.StringMemoryBenchmark.TestCast()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       mov       rcx,19A00308714
       mov       edx,22FE
       mov       r8d,54BEBE0F
       mov       r9d,4C3C3827
       call      qword ptr [7FFCD868FE10]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       add       eax,esi
       mov       [rbx+8],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M01_L06
       mov       eax,edx
       shr       eax,3
       xchg      ax,ax
M01_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r10d,r8d
       mov       r8d,r9d
       xor       r8d,r10d
       rol       r10d,14
       add       r10d,r8d
       rol       r8d,9
       xor       r8d,r10d
       rol       r10d,1B
       add       r10d,r8d
       rol       r8d,13
       mov       r9d,r8d
       add       rcx,8
       dec       eax
       mov       r8d,r10d
       jne       short M01_L00
       test      dl,4
       je        short M01_L02
M01_L01:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
M01_L02:
       mov       eax,edx
       and       rax,7
       mov       eax,[rcx+rax-4]
       shr       eax,8
       or        eax,80000000
       not       edx
       shl       edx,3
       shrx      edx,eax,edx
M01_L03:
       add       edx,r8d
       mov       eax,r9d
       xor       eax,edx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       mov       ecx,edx
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       ret
M01_L04:
       mov       eax,edx
       and       rax,2
       movzx     eax,byte ptr [rcx+rax]
       or        eax,8000
M01_L05:
       test      dl,2
       mov       edx,eax
       je        short M01_L03
       shl       edx,10
       movzx     eax,word ptr [rcx]
       or        edx,eax
       jmp       short M01_L03
M01_L06:
       cmp       edx,4
       jae       near ptr M01_L01
       mov       eax,80
       test      dl,1
       je        short M01_L05
       jmp       short M01_L04
; Total bytes of code 267
```

## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.StringMemoryBenchmark.TestToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rdx,19580208708
       mov       esi,[rbx+8]
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,4EAC582E
       mov       r9d,0C41FDB2
       call      qword ptr [7FFCD86AFAF8]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       add       eax,esi
       mov       [rbx+8],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M01_L06
       mov       eax,edx
       shr       eax,3
       xchg      ax,ax
M01_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r10d,r8d
       mov       r8d,r9d
       xor       r8d,r10d
       rol       r10d,14
       add       r10d,r8d
       rol       r8d,9
       xor       r8d,r10d
       rol       r10d,1B
       add       r10d,r8d
       rol       r8d,13
       mov       r9d,r8d
       add       rcx,8
       dec       eax
       mov       r8d,r10d
       jne       short M01_L00
       test      dl,4
       je        short M01_L02
M01_L01:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
M01_L02:
       mov       eax,edx
       and       rax,7
       mov       eax,[rcx+rax-4]
       shr       eax,8
       or        eax,80000000
       not       edx
       shl       edx,3
       shrx      edx,eax,edx
M01_L03:
       add       edx,r8d
       mov       eax,r9d
       xor       eax,edx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       mov       ecx,edx
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       ret
M01_L04:
       mov       eax,edx
       and       rax,2
       movzx     eax,byte ptr [rcx+rax]
       or        eax,8000
M01_L05:
       test      dl,2
       mov       edx,eax
       je        short M01_L03
       shl       edx,10
       movzx     eax,word ptr [rcx]
       or        edx,eax
       jmp       short M01_L03
M01_L06:
       cmp       edx,4
       jae       near ptr M01_L01
       mov       eax,80
       test      dl,1
       je        short M01_L05
       jmp       short M01_L04
; Total bytes of code 267
```

